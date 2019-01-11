using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS_DEMO
{
    public partial class HOMEPAGE : Form 
    {
        public HOMEPAGE()
        {
            InitializeComponent();
            this.lblTimeClock.Text = DateTime.Now.ToString();

            DateTime dateTime = DateTime.Now;
            tmer = new Timer();
            tmer.Interval = 1000;
            tmer.Tick += new EventHandler(timer2_Tick);
            tmer.Enabled = true;
            tmer.Start();
        }

        private void btnKganya_Click(object sender, EventArgs e)
        {
            //create an object to enable us to reference kganya form and display it on click
            kganya kganyaForm = new kganya();
            kganyaForm.Show();
               
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DatabaseDisplay dbDisply = new DatabaseDisplay();
            dbDisply.Show();
            kganya kganyaForm = new kganya();
            kganyaForm.Close();
           
        }



        private void btnSignout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnAssetMan_Click(object sender, EventArgs e)
        {
            AssetManagement AMS = new AssetManagement();
            AMS.Show();
        }

        private void timerLabel_Tick(object sender, EventArgs e)
        {
            //this.Invoke(new EventHandler(delegate
            //{
            //    lblTimeDisplay.Text = DateTime.Now.ToString();
            //}));
        }

        private void btnTrips_Click(object sender, EventArgs e)
        {
            TripsForm tp = new TripsForm();
            tp.Show();
        }

        private void btnDisplayCases_Click(object sender, EventArgs e)
        {
            //
            CasesForm caseF = new CasesForm();
            caseF.Show();
        }

        private void btnWeddings_Click(object sender, EventArgs e)
        {
            weddingForm wf = new weddingForm();
            wf.Show();
        }

        private void btnDistrictMinistry_Click(object sender, EventArgs e)
        {
            DistrictMinistry dm = new DistrictMinistry();
            dm.Show();
        }
        private int xpos = 0, ypos=0;
        public string mode = "Left-to-Right";


        private void HOMEPAGE_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Kgotsong Welcome to Church Database System";
          xpos =  lblMove.Location.X;
          ypos = lblMove.Location.Y;
          timer1.Start();

          //AdminLogin AL = new AdminLogin();
          //this.Location = new Point(0, 0);
          //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void btnConvertHlono_Click(object sender, EventArgs e)
        {
            ConvertsForm cf = new ConvertsForm();
            cf.Show();
        }

        private void btnChurchFinances_Click(object sender, EventArgs e)
        {
            BudgetForm bf = new BudgetForm();
            bf.Show();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMasogoanaG_Click(object sender, EventArgs e)
        {
            MasogoanaForm masoform = new MasogoanaForm();
            masoform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BarutiForm baruti = new BarutiForm();
            baruti.Show();
        }

        private void btnBomme_Click(object sender, EventArgs e)
        {
            BommeForm mme = new BommeForm();
            mme.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mode == "Left-to-Right")
            {
                if (this.Width == xpos)
                {
                    this.lblMove.Location = new System.Drawing.Point(0, ypos);
                    xpos = 0;

                }
                else{
                    this.lblMove.Location = new System.Drawing.Point(xpos, ypos);
                    
                    xpos += 2;
                }
                }
                else if (mode == "Right-to-Left")
                {
                    if (xpos == 0)
                    {
                        this.lblMove.Location = new System.Drawing.Point(this.Width, ypos);
                        xpos = this.Width;

                    }else{
                        this.lblMove.Location = new System.Drawing.Point(xpos, ypos);
                        
                        xpos -=2;
                    }

                }
            }
          private Timer tmer;
        public void Clock(){
           
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
           this.lblTimeClock.Text = DateTime.Now.ToString();
            
        }

        private void btnMasogoanaLoad_Click(object sender, EventArgs e)
        {
            MasogoanaLeMakgarebeForm mm = new MasogoanaLeMakgarebeForm();
            mm.Show();
        }

        private void btnSubBranches_Click(object sender, EventArgs e)
        {
            SubBranches sb = new SubBranches();
            sb.Show();
        }

        private void btnStudentFellowship_Click(object sender, EventArgs e)
        {
            StudentFellowship sf = new StudentFellowship();
            sf.Show();
        }
                
        }


    }

