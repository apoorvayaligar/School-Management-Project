using SchoolProject.Data;
using SchoolProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using SchoolProject.Data.Migrations;
using System.Data.Entity;


namespace SchoolProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            SetData();
        }
        //BackgroundWorker bw;
        private void SetData()
        {
            //labelStatus.Text = "Setting Up Data";

            //bw = new BackgroundWorker();
            //bw.DoWork += Bw_DoWork;
            //bw.RunWorkerCompleted += Bw_RunWorkerCompleted;
            //bw.RunWorkerAsync();
        }

        //private void Bw_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    try
        //    {
        //        using(var ctx=new SchoolContext())
        //        {
        //            if(!ctx.Students.Any())
        //            {
        //                var students = new List<Student>()
        //                {
        //                  new Student()
        //                  {
        //                      StudentName="Harshitha",
        //                      FeeDetails = new List<FeeDetail>()
        //                      {
        //                          new FeeDetail()
        //                          {
        //                              FeePaid=10000,
        //                              FeeDue=5000
        //                          }
        //                      }

        //                  },
        //                  new Student()
        //                  {
        //                      StudentName="Pruthvi",
        //                      FeeDetails = new List<FeeDetail>()
        //                      {
        //                          new FeeDetail()
        //                          {
        //                              FeePaid=12000,
        //                              FeeDue=3000
        //                          }
        //                      }

        //                  }

        //                };
        //            }

        //            ctx.SaveChanges();
        //            e.Result = "Ready";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void Bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        //{
        //    labelStatus.Text = e.Result.ToString();
        //}

        private void labelStatus_Click(object sender, EventArgs e)
        {

        }

        private void btn_FeeDetail_Click(object sender, EventArgs e)
        {
            try
            {
                var initializer = new MigrateDatabaseToLatestVersion<SchoolContext, Configuration>();
                Database.SetInitializer(initializer);
                using (var ctx=new SchoolContext())
                {
                    var feedetail = new FeeDetail()
                    {
                        
                        Student=ctx.Students.First(),
                        FeePaid=10000,
                        FeeDue=5000
                    };

                    ctx.FeeDetails.Add(feedetail);
                    ctx.SaveChanges();
                    MessageBox.Show("Created");

                    
                }

                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            using(var ctx=new SchoolContext())
            {
                var res = ctx.Students.Select(e1 => e1.StudentDetails.ParentMobileNo);
                foreach (var t in res)
                {
                    MessageBox.Show(t);
                }
            }
        }
    }
}
