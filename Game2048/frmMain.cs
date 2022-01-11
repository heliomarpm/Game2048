using System.Media;

namespace Game2048
{
    public partial class frmMain : Form
    {
        BoardGame _board;

        SoundPlayer soundMerge = new(Application.StartupPath + "/Sounds/merging.wav");
        SoundPlayer soundWrong = new(Application.StartupPath + "/Sounds/wrong.wav");

        public frmMain()
        {
            InitializeComponent();

            Label[,] board = {
                    { lblValue1, lblValue2, lblValue3, lblValue4},
                    { lblValue5, lblValue6, lblValue7, lblValue8},
                    { lblValue9, lblValue10, lblValue11, lblValue12},
                    { lblValue13, lblValue14, lblValue15, lblValue16},
                };

            _board = new BoardGame(board);
            _board.ScoreEvent += _board_ScoreEvent;
            _board.MergeEvent += _board_MergeEvent;
            _board.GameOverEvent += _board_GameOverEvent;
            this.NewGame();
        }

        private void _board_GameOverEvent()
        {
            lblMessage.Visible = true;
        }

        private void _board_MergeEvent(bool merging)
        {
            try
            {
                if (chkSoundEffect.Checked)
                    if (merging)
                        soundMerge.Play();

                    else
                        soundWrong.Play();
            }
            catch (Exception)
            {
                chkSoundEffect.Checked = false;
                chkSoundEffect.Enabled = false;
            }

        }

        private void _board_ScoreEvent(int score)
        {
            lblScore.Text = score.ToString();
        }

        private void NewGame()
        {
            lblMessage.Visible = false;
            _board.NewGame();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {            
            this.NewGame();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                case Keys.Right:
                case Keys.Up:
                case Keys.Down:
                    // left arrow key pressed
                    return MergeNumbers(keyData);

            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private bool MergeNumbers(Keys keyCode)
        {
            //if (sayiYaz() == false)//yeni sayı üretme degeri 0 dönmesi lazım tuşları kullanabilmemiz için
            //{
            switch (keyCode)
            {
                case Keys.Up:
                    _board.MergeDirection(BoardGame.eMergeDirection.Up);
                    return true;
                case Keys.Down:
                    _board.MergeDirection(BoardGame.eMergeDirection.Down);
                    return true;
                case Keys.Left:
                    _board.MergeDirection(BoardGame.eMergeDirection.Left);
                    return true;
                case Keys.Right:
                    _board.MergeDirection(BoardGame.eMergeDirection.Right);
                    return true;

                default:
                    //soundWrong.Play();
                    return false;
            }


            //}
            //else
            //{
            //    // continueToolStripMenuItem.Visible = false;
            //    // lblGameOver.Text = "OYUN BİTTİ";//oyun biterse bunu ekrana basıyoruz.
            //    tekrarOyun = false;
            //    lblGameOver.Visible = true;
            //    btnNewGame.Visible = true;
            //    btnExit.Visible = true;
            //    btnExit.Enabled = true;
            //    btnNewGame.Enabled = true;
            //    this.KeyDown -= new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            //}
        }
    }
}