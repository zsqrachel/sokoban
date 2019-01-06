/*
 * Created by SharpDevelop.
 * User: zsq
 * Date: 2018/12/25
 * Time: 23:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sokoban.UI
{
	/// <summary>
	/// Description of ChooseForm.
	/// </summary>
	public partial class SelectForm : Form
	{
		public SelectForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
//			this.btn1.Click += new System.EventHandler(this.Btn1Click);
//			this.btn2.Click += new System.EventHandler(this.Btn1Click);
//			this.btn3.Click += new System.EventHandler(this.Btn1Click);
//			this.btn4.Click += new System.EventHandler(this.Btn1Click);
//			this.btn5.Click += new System.EventHandler(this.Btn1Click);
//			this.btn6.Click += new System.EventHandler(this.Btn1Click);
//			this.btn7.Click += new System.EventHandler(this.Btn1Click);
//			this.btn8.Click += new System.EventHandler(this.Btn1Click);
//			this.btn9.Click += new System.EventHandler(this.Btn1Click);
//			this.btn10.Click += new System.EventHandler(this.Btn1Click);
//			this.btn11.Click += new System.EventHandler(this.Btn1Click);
//			this.btn12.Click += new System.EventHandler(this.Btn1Click);
//			this.btn13.Click += new System.EventHandler(this.Btn1Click);
//			this.btn14.Click += new System.EventHandler(this.Btn1Click);
//			this.btn15.Click += new System.EventHandler(this.Btn1Click);
//			this.btn16.Click += new System.EventHandler(this.Btn1Click);
//			this.btn17.Click += new System.EventHandler(this.Btn1Click);
//			this.btn18.Click += new System.EventHandler(this.Btn1Click);
//			this.btn19.Click += new System.EventHandler(this.Btn1Click);
//			this.btn20.Click += new System.EventHandler(this.Btn1Click);
//			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void SelectForm_MouseClick(object sender, MouseEventArgs e)
        {

            Point p = e.Location;
            if(SelectPoint(p)==-1){
            	
            }else{
            	MainForm.z = SelectPoint(p);
            	MainForm mf = new MainForm();
				mf.Show();
            }
//            string X = p.X.ToString();
//            string Y = p.Y.ToString();
//            MessageBox.Show(p.ToString(),X+Y);
			
            }
		 private int SelectPoint(Point p){
		 	if((p.X>80&&p.X<135)&&(p.Y>150&&p.Y<205)){
		 		return 1;
		 	}else if((p.X>200&&p.X<240)&&(p.Y>150&&p.Y<205)){
		 		return 2;
		 	}else if((p.X>300&&p.X<355)&&(p.Y>150&&p.Y<205)){
		 		return 3;
		 	}else if((p.X>420&&p.X<460)&&(p.Y>150&&p.Y<205)){
		 		return 4;
		 	}else if((p.X>430&&p.X<580)&&(p.Y>150&&p.Y<205)){
		 		return 5;
		 	}else if((p.X>60&&p.X<100)&&(p.Y>230&&p.Y<285)){
		 		return 6;
		 	}else if((p.X>170&&p.X<210)&&(p.Y>230&&p.Y<285)){
		 		return 7;
		 	}else if((p.X>280&&p.X<320)&&(p.Y>230&&p.Y<285)){
		 		return 8;
		 	}else if((p.X>390&&p.X<430)&&(p.Y>230&&p.Y<285)){
		 		return 9;
		 	}else if((p.X>500&&p.X<590)&&(p.Y>230&&p.Y<285)){
		 		return 10;
		 	}else if((p.X>85&&p.X<165)&&(p.Y>305&&p.Y<360)){
		 		return 11;
		 	}else if((p.X>235&&p.X<305)&&(p.Y>305&&p.Y<360)){
		 		return 12;
		 	}else if((p.X>380&&p.X<455)&&(p.Y>305&&p.Y<360)){
		 		return 13;
		 	}else if((p.X>530&&p.X<600)&&(p.Y>305&&p.Y<360)){
		 		return 14;
		 	}else if((p.X>60&&p.X<130)&&(p.Y>385&&p.Y<435)){
		 		return 15;
		 	}else if((p.X>210&&p.X<280)&&(p.Y>385&&p.Y<435)){
		 		return 16;
		 	}else if((p.X>355&&p.X<420)&&(p.Y>385&&p.Y<435)){
		 		return 17;
		 	}else if((p.X>495&&p.X<570)&&(p.Y>385&&p.Y<435)){
		 		return 18;
		 	}else if((p.X>90&&p.X<160)&&(p.Y>465&&p.Y<515)){
		 		return 19;
		 	}else if((p.X>235&&p.X<310)&&(p.Y>465&&p.Y<515)){
		 		return 20;
		 	}
		 	return -1;
		 		
        }
//		void Btn1Click(object sender, EventArgs e)
//		{
//			Button btn = (Button)sender;
//			MainForm.z =SelectBtn(btn.Name);
//			MainForm mf = new MainForm();
//
//			mf.Show();
//			this.Close();
//		}
//		private int SelectBtn(string Name){
//			switch(Name){
//				case "btn1":
//					return 1;
//				case "btn2":
//					return 2;
//				case "btn3":
//					return 3;
//				case "btn4":
//					return 4;
//				case "btn5":
//					return 5;
//				case "btn6":
//					return 6;
//				case "btn7":
//					return 7;
//				case "btn8":
//					return 8;
//				case "btn9":
//					return 9;
//				case "btn10":
//					return 10;
//				case "btn11":
//					return 11;
//				case "btn12":
//					return 12;
//				case "btn13":
//					return 13;
//				case "btn14":
//					return 14;
//				case "btn15":
//					return 15;
//				case "btn16":
//					return 16;
//				case "btn17":
//					return 17;
//				case "btn18":
//					return 18;
//				case "btn19":
//					return 19;
//				case "btn20":
//					return 20;
//				
//			}
//			return -1;
//		}
	}
}
