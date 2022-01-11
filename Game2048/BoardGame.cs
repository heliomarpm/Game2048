using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace Game2048
{
    internal class BoardGame
    {
        public enum eMergeDirection
        {
            Left = Keys.Left,
            Right = Keys.Right,
            Up = Keys.Up,
            Down = Keys.Down,
        }
        // Assuming you need a custom signature for your event. If not, use an existing standard event delegate
        public delegate void MergeDelegate(bool merging);
        public event MergeDelegate MergeEvent;

        public delegate void ScoreDelegate(int score);
        public event ScoreDelegate ScoreEvent;

        public delegate void GameOverDelegate();
        public event GameOverDelegate GameOverEvent;

        private record BoardColor
        {
            public BoardColor(Color backColor, Color foreColor)
            {
                this.BackColor = backColor;
                this.ForeColor = foreColor;
            }

            public Color BackColor { get; set; }

            public Color ForeColor { get; set; }
        }

        private Label[,] _board;
        //private List<BoardColor> _boardColors;
        private Dictionary<string, BoardColor> _boardColors;
        private Random _random = new();
        private bool _gameOver;

        public BoardGame(Label[,] board)
        {
            this._board = board ?? throw new ArgumentNullException("Argumento não opcional");
            this.Score = 0;

            _boardColors = new Dictionary<string, BoardColor>
            {
                { "", new BoardColor(Color.Snow, Color.Black) },
                { "2", new BoardColor(Color.LightGray, Color.Black) },
                { "4", new BoardColor( Color.Gray, Color.Black) },
                { "8", new BoardColor(Color.Orange, Color.Black) },
                { "16", new BoardColor(Color.OrangeRed, Color.Black) },
                { "32", new BoardColor(Color.LightSkyBlue, Color.Black) },
                { "64", new BoardColor(Color.SteelBlue, Color.Black) },
                { "128", new BoardColor(Color.DeepSkyBlue, Color.Black) },
                { "256", new BoardColor(Color.MediumPurple, Color.Black) },
                { "512", new BoardColor(Color.BlueViolet, Color.Black) },
                { "1024", new BoardColor(Color.DarkSeaGreen, Color.Black) },
                { "2048", new BoardColor(Color.ForestGreen, Color.Black) }
            };

        }

        private void RaiseMergeEvent(bool merging)
        {
            var eventHandler = this.MergeEvent;

            // Check for no subscribers
            if (eventHandler != null)
                MergeEvent(merging);
        }

        private int _score;
        public int Score
        {
            get { return _score; }
            private set
            {
                _score = value;

                var eventHandler = this.ScoreEvent;
                if (eventHandler != null)
                {
                    ScoreEvent(value);
                }
            }
        }

        public void NewGame()
        {
            this._gameOver = false;
            this.Score = 0;

            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    _board[row, col].Text = "";
                }
            }

            SortNumbers(3);
        }

        private void SortNumbers(int sortCount = 1)
        {
            List<int> numbers = new();

            for (int i = 0; i < sortCount; i++)
            {
                numbers.Clear();

                for (int row = 0; row < 4; row++)
                {
                    for (int col = 0; col < 4; col++)
                    {
                        if (_board[row, col].Text == "")
                            numbers.Add(row * 4 + col + 1);
                    }
                }

                if (numbers.Count > 0)
                {
                    int pos = numbers[_random.Next(0, numbers.Count - 1)];
                    int row = (pos - 1) / 4;
                    int col = (pos - 1) - row * 4;
                    int rnd = _random.Next(1, 10);

                    string value = (rnd <= 6) ? "2" : "4";
                    _board[row, col].Text = value;

                }
            }

            ColoringBoard();
        }

        private void ColoringBoard()
        {
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    var key = _board[row, col].Text;
                    var bColor = _boardColors[key];

                    _board[row, col].BackColor = bColor.BackColor;
                    _board[row, col].ForeColor = bColor.ForeColor;
                }
            }
        }

        public void MergeDirection(eMergeDirection direction)
        {
            if (!_gameOver)
            {
                switch (direction)
                {
                    case eMergeDirection.Left:
                        PressKeyLeft();
                        break;
                    case eMergeDirection.Right:
                        PressKeyRight();
                        break;
                    case eMergeDirection.Up:
                        PressKeyUp();
                        break;
                    case eMergeDirection.Down:
                        PressKeyDown();
                        break;
                    default:
                        //RaiseMergeEvent(false);
                        return;
                }

                if (GameOver())
                {
                    if (this.GameOverEvent != null)
                        GameOverEvent();
                }
            }
        }

        private bool ChangeTileValue(Label newTile, Label oldTile)
        {
            newTile.Text = oldTile.Text;
            oldTile.Text = "";
            return true;
        }

        private void PressKeyUp()
        {
            bool raiseEvent = false;
            bool merge = false;
            bool sortNumber = false;

            for (int col = 0; col < 4; col++)
            {
                int scroll = 0;

                for (int row = 0; row < 4; row++)
                {
                    Label tile = _board[row, col];

                    if (tile.Text == "")
                    {
                        scroll++;
                    }
                    else
                    {
                        for (int prevRow = row; prevRow >= 0; prevRow--)
                        {
                            if (_board[prevRow, col].Text == "")
                            {
                                sortNumber = true;
                                break;
                            }
                        }

                        for (int nextRow = row + 1; nextRow < 4; nextRow++)
                        {
                            if (_board[nextRow, col].Text != "")
                            {
                                if (tile.Text == _board[nextRow, col].Text)
                                {
                                    merge = true;
                                }
                                break;
                            }
                        }

                        if (row + 1 < 4)
                        {
                            bool clearTile = true;

                            for (int nextRow = row + 1; nextRow < 4; nextRow++)
                            {
                                if (_board[nextRow, col].Text != "")
                                {
                                    if (tile.Text == _board[nextRow, col].Text)
                                    {
                                        int value = int.Parse(tile.Text) * 2;
                                        this.Score += value;
                                        tile.Text = value.ToString();

                                        raiseEvent = true;
                                        sortNumber = true;
                                        clearTile = false;

                                        if (scroll != 0)
                                        {
                                            ChangeTileValue(_board[row - scroll, col], tile);
                                        }
                                        _board[nextRow, col].Text = "";
                                    }
                                    break;
                                }
                            }

                            if (clearTile && scroll != 0)
                            {
                                raiseEvent = ChangeTileValue(_board[row - scroll, col], tile);
                            }

                        }
                        else if (scroll != 0)
                        {
                            raiseEvent = ChangeTileValue(_board[row - scroll, col], tile);
                        }

                    }
                }
            }

            if (raiseEvent) RaiseMergeEvent(merge);
            if (sortNumber) SortNumbers();
        }

        private void PressKeyDown()
        {
            bool raiseEvent = false;
            bool merge = false;
            bool sortNumber = false;

            for (int col = 0; col < 4; col++)
            {
                int scroll = 0;

                for (int row = 3; row >= 0; row--)
                {
                    Label tile = _board[row, col];

                    if (tile.Text == "")
                    {
                        scroll++;
                    }
                    else
                    {
                        // merge value
                        for (int prevRow = row - 1; prevRow >= 0; prevRow--)
                        {
                            if (_board[prevRow, col].Text != "")
                            {
                                if (tile.Text == _board[prevRow, col].Text)
                                {
                                    merge = true;
                                }
                                break;
                            }
                        }

                        // sortNumber
                        for (int nextRow = row + 1; nextRow < 4; nextRow++)
                        {
                            if (_board[nextRow, col].Text == "")
                            {
                                sortNumber = true;
                                break;
                            }
                        }

                        if (row - 1 >= 0)
                        {
                            bool clearTile = true;

                            for (int prevRow = row - 1; prevRow >= 0; prevRow--)
                            {
                                if (_board[prevRow, col].Text != "")
                                {
                                    if (tile.Text == _board[prevRow, col].Text)
                                    {
                                        int value = int.Parse(tile.Text) * 2;
                                        this.Score += value;
                                        tile.Text = value.ToString();

                                        raiseEvent = true;
                                        sortNumber = true;
                                        clearTile = false;

                                        if (scroll != 0)
                                        {
                                            ChangeTileValue(_board[row + scroll, col], tile);
                                        }
                                        _board[prevRow, col].Text = "";
                                    }
                                    break;
                                }
                            }

                            if (clearTile && scroll != 0)
                            {
                                raiseEvent = ChangeTileValue(_board[row + scroll, col], tile);
                            }

                        }
                        else if (scroll != 0)
                        {
                            raiseEvent = ChangeTileValue(_board[row + scroll, col], tile);
                        }

                    }
                }
            }

            if (raiseEvent) RaiseMergeEvent(merge);
            if (sortNumber) SortNumbers();
        }

        private void PressKeyLeft()
        {
            bool raiseEvent = false;
            bool merge = false;
            bool sortNumber = false;

            for (int row = 0; row < 4; row++)
            {
                int scroll = 0;
                for (int col = 0; col < 4; col++)
                {
                    Label tile = _board[row, col];

                    if (tile.Text == "")
                    {
                        scroll++;
                    }
                    else
                    {
                        for (int prevCol = col - 1; prevCol >= 0; prevCol--)
                        {
                            if (_board[row, prevCol].Text == "")
                            {
                                sortNumber = true;
                                break;
                            }
                        }

                        for (int nextCol = col + 1; nextCol < 4; nextCol++)
                        {
                            if (_board[row, nextCol].Text != "")
                            {
                                if (_board[row, nextCol].Text == tile.Text)
                                {
                                    merge = true;
                                }
                                break;
                            }
                        }

                        if (col + 1 < 4)
                        {
                            bool clearTile = true;

                            for (int nextCol = col + 1; nextCol < 4; nextCol++)
                            {
                                if (_board[row, nextCol].Text != "")
                                {
                                    if (tile.Text == _board[row, nextCol].Text)
                                    {
                                        int value = int.Parse(tile.Text) * 2;
                                        this.Score += value;
                                        tile.Text = value.ToString();

                                        raiseEvent = true;
                                        sortNumber = true;
                                        clearTile = false;

                                        if (scroll != 0)
                                        {
                                            ChangeTileValue(_board[row, col - scroll], tile);
                                        }
                                        _board[row, nextCol].Text = "";
                                    }
                                    break;
                                }
                            }

                            if (clearTile == true && scroll != 0)
                            {
                                raiseEvent = ChangeTileValue(_board[row, col - scroll], tile);
                            }

                        }
                        else if (scroll != 0)
                        {
                            raiseEvent = ChangeTileValue(_board[row, col - scroll], tile);
                        }

                    }
                }
            }

            if (raiseEvent) RaiseMergeEvent(merge);
            if (sortNumber) SortNumbers();
        }

        private void PressKeyRight()
        {
            bool raiseEvent = false;
            bool merge = false;
            bool sortNumber = false;

            for (int row = 0; row < 4; row++)
            {
                int scroll = 0;

                for (int col = 3; col >= 0; col--)
                {
                    Label tile = _board[row, col];


                    if (tile.Text == "")
                    {
                        scroll++;
                    }
                    else
                    {
                        for (int prevCol = col - 1; prevCol >= 0; prevCol--)
                        {
                            if (_board[row, prevCol].Text != "")
                            {
                                if (_board[row, prevCol].Text == tile.Text)
                                {
                                    merge = true;
                                }
                                break;
                            }
                        }

                        for (int nextCol = col + 1; nextCol < 4; nextCol++)
                        {
                            if (_board[row, nextCol].Text == "")
                            {
                                sortNumber = true;
                                break;
                            }
                        }

                        if (col - 1 >= 0)
                        {
                            bool clearTile = true;

                            for (int prevCol = col - 1; prevCol >= 0; prevCol--)
                            {
                                if (_board[row, prevCol].Text != "")
                                {
                                    if (tile.Text == _board[row, prevCol].Text)
                                    {
                                        int value = int.Parse(tile.Text) * 2;
                                        this.Score += value;
                                        tile.Text = value.ToString();

                                        raiseEvent = true;
                                        sortNumber = true;
                                        clearTile = false;

                                        if (scroll != 0)
                                        {
                                            ChangeTileValue(_board[row, col + scroll], tile);
                                        }
                                        _board[row, prevCol].Text = "";
                                    }
                                    break;
                                }
                            }

                            if (clearTile == true && scroll != 0)
                            {
                                raiseEvent = ChangeTileValue(_board[row, col + scroll], tile);
                            }

                        }
                        else if (scroll != 0)
                        {
                            raiseEvent = ChangeTileValue(_board[row, col + scroll], tile);
                        }

                    }
                }
            }

            if (raiseEvent) RaiseMergeEvent(merge);
            if (sortNumber) SortNumbers();
        }



        private bool GameOver()
        {
            _gameOver = false;

            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    if (_board[row, col].Text == "")
                    {
                        return false;
                    }
                    for (int nextCol = col + 1; nextCol < 4; nextCol++)
                    {
                        if (_board[row, col].Text != "")
                        {
                            if (_board[row, col].Text == _board[row, nextCol].Text)
                            {
                                return false;
                            }
                            break;
                        }
                    }
                }
            }

            for (int col = 0; col < 4; col++)
            {
                for (int row = 0; row < 4; row++)
                {
                    for (int nextRow = row + 1; nextRow < 4; nextRow++)
                    {
                        if (_board[nextRow, col].Text != "")
                        {
                            if (_board[row, col].Text == _board[nextRow, col].Text)
                            {
                                return false;
                            }
                            break;
                        }
                    }
                }
            }

            _gameOver = true;
            return true;

        }

    }

}