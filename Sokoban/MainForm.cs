/*
 * Created by SharpDevelop.
 * User: win10
 * Date: 2018/12/17
 * Time: 21:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Sokoban.model;

namespace Sokoban
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	
		public partial class MainForm : Form
	{
		public static int z = 1;
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
		
		Sokoban.model.PersonElement element;
		Sokoban.model.PersonInDestinitionElement element1;
		Game game;
		//GameElement[,] map = new GameElement[8,8];
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			ChooseMap(z++);
			PersonElement.s = 0;
			this.KeyDown += new KeyEventHandler(MainForm_KeyDown);
			
		}
		void MainForm_KeyDown(object sender,KeyEventArgs e)
		{
			if(game.Misjudgement() == false){MessageBox.Show("地图有误，请重试！"); return;}
			if(game.GetCurrentPerson() != null){
				switch(e.KeyCode){
					case Keys.Up:
						game.GetCurrentPerson().MoveInForm(this,Direction.UP,resources);
						break;
					case Keys.Down:
						game.GetCurrentPerson().MoveInForm(this,Direction.DOWN,resources);
						break;
					case Keys.Left:					
						game.GetCurrentPerson().MoveInForm(this,Direction.LEFT,resources);
						break;
					case Keys.Right:					
						game.GetCurrentPerson().MoveInForm(this,Direction.RIGHT,resources);
						break;
				}
			}else{
					switch(e.KeyCode){
					case Keys.Up:
						game.GetCurrentPersonInCage().MoveInForm(this,Direction.UP,resources);
						break;
					case Keys.Down:
						game.GetCurrentPersonInCage().MoveInForm(this,Direction.DOWN,resources);
						break;
					case Keys.Left:					
						game.GetCurrentPersonInCage().MoveInForm(this,Direction.LEFT,resources);
						break;
					case Keys.Right:					
						game.GetCurrentPersonInCage().MoveInForm(this,Direction.RIGHT,resources);
						break;
				}
			}
		}
		private void ChooseMap(int i){
				switch(i){
					case 1:
						map1();
						break;
					case 2:
						map2();
						break;
					case 3:
						map3();
						break;
					case 4:
						map4();
						break;
					case 5:
						map5();
						break;
					case 6:
						map6();
						break;
					case 7:
						map7();
						break;
					case 8:
						map8();
						break;
					case 9:
						map9();
						break;
					case 10:
						map10();
						break;
					case 11:
						map11();
						break;
					case 12:
						map12();
						break;
					case 13:
						map13();
						break;
					case 14:
						map14();
						break;
					case 15:
						map15();
						break;
					case 16:
						map16();
						break;
					case 17:
						map17();
						break;
					case 18:
						map18();
						break;
					case 19:
						map19();
						break;
					case 20:
						map20();
						break;
				}
		}
		private void person(){
			PictureBox pbx = new PictureBox();
			if(game.GetCurrentPerson() != null){
			pbx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.wolf.down")));
			pbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			pbx.Size = new Size(new Point(50,50));
			pbx.Location = new Point(100,100);
			this.Controls.Add(pbx);
			element = new Sokoban.model.PersonElement();
			element.Control = pbx;
			element.ShowInForm(this);	
			}else{
				pbx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.wolf.cage.down")));
			pbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			pbx.Size = new Size(new Point(50,50));
			pbx.Location = new Point(100,100);
			this.Controls.Add(pbx);
			element1 = new Sokoban.model.PersonInDestinitionElement();
			element1.Control = pbx;
			element1.ShowInForm(this);	
			}
		}
			//element.CurrentPosition = new Sokoban.model.Position(1,1);	
		
		private void map1(){
			int[,] data = {
				{128,128,4,4,4,128,128,128},
				{128,128,4,1,4,128,128,128},
				{128,128,4,2,4,4,4,4},
				{4,4,4,16,2,16,1,4},
				{4,1,2,16,8,4,4,4},
				{4,4,4,4,16,4,128,128},
				{128,128,128,4,1,4,128,128},
				{128,128,128,4,4,4,128,128}
			};
			game = new Game(data.GetLength(0),data.GetLength(1));
			this.game.LoadMap(data,this,resources);
			this.ClientSize = new System.Drawing.Size((data.GetLength(1)*50), (data.GetLength(0)*50));
		}
//		private void newmap1(){
//			int[,] data = {
//				{128,128,4,4,4,128,128,128},
//				{128,128,4,1,4,128,128,128},
//				{128,128,4,2,4,4,4,4},
//				{4,4,4,16,2,16,1,4},
//				{4,1,2,16,8,4,4,4},
//				{4,4,4,4,16,4,128,128},
//				{128,128,128,4,1,4,128,128},
//				{128,128,128,4,4,4,128,128}
//			};
//			this.game.LoadMap(data,this,resources);
//		}
		private void map2(){
			int[,] data = {
				{128,128,128,128,128,4,4,4,4,4,4,4,128},
				{128,128,128,128,128,4,2,2,4,2,2,4,128},
				{128,128,128,128,128,4,2,2,16,16,2,4,128},
				{4,4,4,4,4,4,2,16,4,2,2,4,128},
				{4,1,1,1,4,4,4,2,4,2,2,4,128},
				{4,1,2,2,4,2,2,16,2,4,2,2,4},
				{4,1,2,2,2,2,16,2,16,2,16,2,4},
				{4,1,2,2,4,2,2,16,2,4,2,2,4},
				{4,1,1,1,4,4,4,2,4,2,2,4,128},
				{4,4,4,4,4,4,2,16,2,2,2,4,128},
				{128,128,128,128,128,4,2,2,2,8,2,4,128},
				{128,128,128,128,128,4,4,4,4,4,4,4,128}
				
			};
			 game = new Game(data.GetLength(0),data.GetLength(1));
			this.game.LoadMap(data,this,resources);
			this.ClientSize = new System.Drawing.Size((data.GetLength(1)*50), (data.GetLength(0)*50));
		}
//		private void newmap2(){
//			int[,] data = {
//				{128,128,128,128,128,4,4,4,4,4,4,4,128},
//				{128,128,128,128,128,4,2,2,4,2,2,4,128},
//				{128,128,128,128,128,4,2,2,16,16,2,4,128},
//				{4,4,4,4,4,4,2,16,4,2,2,4,128},
//				{4,1,1,2,4,4,4,2,4,2,2,4,128},
//				{4,1,1,16,2,2,2,16,2,4,2,16,4},
//				{4,1,2,2,2,2,2,16,2,2,2,2,4},
//				{4,1,2,2,2,2,2,16,2,4,2,2,4},
//				{4,1,1,1,2,4,4,2,4,2,2,4,128},
//				{4,4,4,4,4,4,2,16,2,2,2,4,128},
//				{128,128,128,128,128,4,2,2,2,8,2,4,128},
//				{128,128,128,128,128,4,4,4,4,4,4,4,128}
//				
//			};
//			 game = new Game(data.GetLength(0),data.GetLength(1));
//			this.game.LoadMap(data,this,resources);
//			this.ClientSize = new System.Drawing.Size((data.GetLength(1)*50), (data.GetLength(0)*50));
//		}
			private void map3(){
				int[,] data = {
					{128,128,128,4,4,4,4,4,4,4,128,128,128},
					{4,4,4,4,2,2,2,2,2,4,128,128,128},
					{4,2,2,2,1,4,4,4,2,4,128,128,128},
					{4,2,4,2,4,2,2,2,2,4,4,128,128},
					{4,2,4,2,16,2,16,4,1,2,4,128,128},
					{4,2,4,2,2,1,16,2,4,2,4,128,128},
					{4,2,1,4,16,2,16,2,4,2,4,128,128},
					{4,4,2,2,2,2,4,2,4,2,4,4,4,},
					{128,4,2,4,4,4,1,2,2,2,2,8,4},
					{128,4,2,2,2,2,2,4,4,2,2,2,4},
					{128,4,4,4,4,4,4,4,4,4,4,4,4}
				};
				game = new Game(data.GetLength(0),data.GetLength(1));
				this.game.LoadMap(data,this,resources);
				this.ClientSize = new System.Drawing.Size((data.GetLength(1)*50), (data.GetLength(0)*50));
			}
						private void map4(){
				int[,] data = new int[,]
            {
                {128,128,128,128,128,128,4,4,4,4,4,4,4,4,4},
                {128,128,128,128,128,128,4,2,2,2,2,2,2,2,4},
                {128,128,128,128,128,128,4,16,2,16,16,16,2,2,4},
                {128,128,128,128,128,128,4,2,2,2,4,2,16,2,4},
                {128,128,128,128,128,128,4,2,2,2,16,8,16,2,4},
                {128,128,128,128,4,4,4,16,2,16,2,4,2,4,4},
                {128,128,128,128,4,2,2,2,16,4,16,4,2,4,128},
                {4,4,4,4,4,2,4,2,2,4,2,2,2,4,128},
                {4,1,1,1,2,2,4,2,16,4,2,4,4,4,128},
                {4,1,1,1,1,1,2,2,2,4,2,4,128,128,128},
                {4,1,1,1,1,1,4,2,16,4,2,4,128,128,128},
                {4,4,4,4,4,4,4,4,2,2,2,4,128,128,128},
                {128,128,128,128,128,128,128,4,4,4,4,4,128,128,128}
             };
				game = new Game(data.GetLength(0),data.GetLength(1));
				this.game.LoadMap(data,this,resources);
				this.ClientSize = new System.Drawing.Size((data.GetLength(1)*50), (data.GetLength(0)*50));
			}
			private void map5(){
				int[,] data = new int[, ]
            {
               {128,4,4,4,4,128,128,4,4,4,4,4,4},
               {128,4,2,2,4,4,4,4,2,2,2,2,4},
               {4,4,16,2,2,2,32,2,32,32,2,2,4},
               {4,2,32,2,32,2,2,2,2,32,4,2,4},
               {4,2,1,2,2,2,4,4,4,2,2,2,4},
               {4,4,4,4,4,4,2,2,2,4,8,4,4},
               {4,2,32,2,1,2,32,2,2,32,32,2,4},
               {4,2,2,2,4,2,2,2,4,2,2,2,4},
               {4,4,32,2,2,2,32,2,4,16,4,2,4},
               {128,4,2,2,4,4,4,4,4,2,2,2,4},
               {128,4,4,4,4,128,128,128,4,4,4,4,4}
            };
				game = new Game(data.GetLength(0),data.GetLength(1));
				this.game.LoadMap(data,this,resources);
				this.ClientSize = new System.Drawing.Size((data.GetLength(1)*50), (data.GetLength(0)*50));
			}
			private void map6(){
				int[,] data = new int[,]
            {  
                {128,128,4,4,4,4,4,4,4,4,4,128,128,128,128,128},
                {128,128,4,2,2,2,2,4,2,2,4,128,128,128,128,128},
                {4,4,4,2,4,16,2,2,16,2,4,4,4,4,128,128},
                {4,2,2,16,2,2,4,4,1,1,4,2,2,4,4,4},
                {4,2,4,2,2,16,2,4,1,1,16,2,16,2,2,4},
                {4,2,16,16,2,2,16,4,1,1,2,2,4,2,2,4},
                {4,4,2,2,4,2,2,1,1,1,4,16,2,2,2,4},
                {128,4,16,2,8,2,4,1,1,1,4,2,16,2,2,4},
                {128,4,2,2,2,2,4,1,1,1,16,2,2,2,4,4},
                {128,4,2,4,4,16,2,4,4,4,2,2,2,4,4,128},
                {128,4,2,2,2,16,2,2,2,2,2,4,4,4,128,128},
                {128,4,2,2,4,4,4,4,4,4,4,4,128,128,128,128},
                {128,4,4,4,4,128,128,128,128,128,128,128,128,128,128,128}
			};
				game = new Game(data.GetLength(0),data.GetLength(1));
				this.game.LoadMap(data,this,resources);
				this.ClientSize = new System.Drawing.Size((data.GetLength(1)*50), (data.GetLength(0)*50));
			}
			private void map7(){
				int[,] data = new int[,]
            {
                {4,4,4,4,128,128,128,128,128,128,128,128,128,128,128},
                {4,2,2,4,128,128,128,128,128,128,128,128,128,128,128},
                {4,2,2,4,4,4,4,4,4,4,4,4,4,128,128},
                {4,2,2,2,2,4,4,2,2,2,2,2,4,128,128},
                {4,1,1,4,2,2,2,2,16,16,4,2,4,128,128},
                {4,1,1,2,2,4,4,2,2,2,16,2,4,4,4,},
                {4,1,1,4,2,2,4,4,16,4,2,16,2,2,4},
                {4,1,1,2,2,2,4,2,8,16,2,16,2,2,4},
                {4,1,1,4,2,2,4,2,16,2,16,2,2,2,4},
                {4,2,1,2,2,2,4,2,16,2,16,2,4,4,4},
                {4,2,2,4,2,2,4,2,2,2,4,4,4,128,128},
                {4,2,2,4,2,2,2,2,4,4,4,128,128,128,128},
                {4,4,4,4,4,4,4,4,4,128,128,128,128,128,128},
            };
				game = new Game(data.GetLength(0),data.GetLength(1));
				this.game.LoadMap(data,this,resources);
				this.ClientSize = new System.Drawing.Size((data.GetLength(1)*50), (data.GetLength(0)*50));
			}
			private void map8(){
				 int[,] data = new int[,]
            { 
                {128,128,128,128,4,4,4,4,4,128,128,128,128,128,128},
                {4,4,4,4,4,2,2,2,4,128,128,128,128,128,128},
                {4,2,2,2,16,2,8,2,4,128,128,128,128,128,128},
                {4,2,2,16,2,4,1,4,4,4,4,4,128,128,128},
                {4,4,16,2,4,4,1,4,4,2,2,4,4,4,4,},
                {128,4,2,2,1,1,1,1,1,2,16,4,2,2,4},
                {128,4,2,16,4,4,1,4,4,2,2,4,16,2,4},
                {128,4,2,2,2,4,1,4,4,2,2,2,2,2,4},
                {128,4,4,4,2,16,2,4,4,4,4,4,2,4,4},
                {128,128,128,4,2,4,16,2,2,2,2,2,16,2,4},
                {128,128,128,4,2,2,2,2,4,4,4,2,2,2,4},
                {128,128,128,4,4,4,4,4,4,128,4,4,4,4,4,},
        };
				game = new Game(data.GetLength(0),data.GetLength(1));
				this.game.LoadMap(data,this,resources);
				this.ClientSize = new System.Drawing.Size((data.GetLength(1)*50), (data.GetLength(0)*50));
			}
			private void map9(){
				int[,] data = new int[,]
            {
                {128,128,128,128,128,128,128,4,4,4,4,4,},
 				{128,128,4,4,4,4,4,4,2,2,2,4,},
 				{4,4,4,2,2,2,2,1,2,16,2,4,},
 				{4,2,16,2,2,4,16,1,4,16,4,4,},
 				{4,2,2,4,2,2,8,1,4,2,2,4,},
 				{4,4,2,4,4,4,4,1,2,2,2,4,},
 				{128,4,2,16,2,2,4,32,4,4,4,4,},
 				{128,4,2,4,4,2,4,1,2,2,4,128,},
 				{128,4,2,2,2,2,2,1,4,2,4,128,},
 				{128,4,4,4,16,2,2,2,2,2,4,128,},
 				{128,128,128,4,2,2,4,4,4,4,4,128,},
 				{128,128,128,4,4,4,4,128,128,128,128,128,}
				};
				game = new Game(data.GetLength(0),data.GetLength(1));
				this.game.LoadMap(data,this,resources);
				this.ClientSize = new System.Drawing.Size((data.GetLength(1)*50), (data.GetLength(0)*50));
			}
			private void map10(){
				int[,] data = new int[,]
				{
					{128,128,128,128,128,128,128,128,4,4,4,4,4},
 					{128,128,128,128,128,128,128,128,4,2,2,2,4},
 					{4,4,4,4,4,4,4,4,4,2,4,2,4},
					{4,2,16,2,16,2,16,2,16,2,2,2,4},
					{4,2,4,1,4,1,4,1,4,2,16,4,4},
					{4,1,1,1,1,1,1,1,2,8,2,4,128},
					{4,2,4,2,4,2,4,2,4,16,4,4,4},
 					{4,2,16,2,16,2,16,2,16,2,2,2,4},
 					{4,4,4,4,4,4,4,4,4,2,4,2,4},
 					{128,128,128,128,128,128,128,128,4,2,2,2,4},
					{128,128,128,128,128,128,128,128,4,4,4,4,4}
				};
				game = new Game(data.GetLength(0),data.GetLength(1));
				this.game.LoadMap(data,this,resources);
				this.ClientSize = new System.Drawing.Size((data.GetLength(1)*50), (data.GetLength(0)*50));
			}
			private void map11(){
				int[,] data = new int[,]
				{
					{128,128,128,128,128,128,128,128,128,4,4,4,4,4,128,128,},
 					{128,128,128,128,128,128,128,128,128,4,2,2,2,4,128,128,},
 					{4,4,4,4,4,4,4,4,4,4,2,32,2,4,4,4,},
 					{4,2,2,2,2,2,2,2,2,2,2,1,2,2,2,4,},
 					{4,2,16,16,16,16,32,32,32,32,16,1,1,1,8,4,},
 					{4,2,2,2,2,2,2,2,2,2,2,1,2,2,2,4,},
					{4,4,4,4,4,4,4,4,4,4,2,32,2,4,4,4,},
 					{128,128,128,128,128,128,128,128,128,4,2,2,2,4,128,128,},
					 {128,128,128,128,128,128,128,128,128,4,4,4,4,4,128,128,}
				};
				game = new Game(data.GetLength(0),data.GetLength(1));
				this.game.LoadMap(data,this,resources);
				this.ClientSize = new System.Drawing.Size((data.GetLength(1)*50), (data.GetLength(0)*50));
			}
			private void map12(){
				int[,] data = new int[,]
				{
					{128,128,128,128,128,4,4,4,4,128,128,128,128,},
 					{4,4,4,4,4,4,2,2,4,4,4,4,4,},
 					{4,8,16,2,2,2,2,16,2,2,16,2,4,},
 					{4,16,4,4,4,2,16,2,4,2,4,2,4,},
 					{4,2,2,4,2,2,4,2,16,2,2,2,4,},
 					{4,2,16,4,2,2,2,2,4,2,4,4,4,},
 					{4,2,2,16,2,4,16,4,2,2,2,4,128,},
 					{4,1,1,1,1,1,1,1,1,1,2,4,128,},
 					{128,128,128,128,128,128,128,4,4,4,4,4,128,}
				};
				game = new Game(data.GetLength(0),data.GetLength(1));
				this.game.LoadMap(data,this,resources);
				this.ClientSize = new System.Drawing.Size((data.GetLength(1)*50), (data.GetLength(0)*50));
			}
			private void map13(){
				int[,] data = new int[,]
				{
					{128,4,4,4,4,4,4,4,4,4,4,128,128,},
 					{128,4,2,2,2,4,4,2,2,2,4,4,4,},
					 {128,4,2,16,2,2,2,2,2,2,16,2,4,},
 					{128,4,4,2,2,4,4,2,4,2,8,2,4,},
					 {128,4,2,2,4,4,2,16,2,4,2,4,4,},
					 {128,4,2,16,1,1,1,1,1,1,2,4,128,},
					 {4,4,2,4,4,4,2,1,2,4,2,4,128,},
					 {4,2,2,2,2,2,16,4,4,4,2,4,128,},
					 {4,2,2,2,4,2,2,2,2,16,2,4,128,},
					 {4,4,4,4,4,16,4,2,4,4,4,4,128,},
					 {128,128,128,128,4,2,2,2,4,128,128,128,128,},
 					{128,128,128,128,4,4,4,4,4,128,128,128,128,}
				};
				game = new Game(data.GetLength(0),data.GetLength(1));
				this.game.LoadMap(data,this,resources);
				this.ClientSize = new System.Drawing.Size((data.GetLength(1)*50), (data.GetLength(0)*50));
			}
			private void map14(){
				int[,] data = new int[,]
				{
					{4,4,4,4,4,4,4,4,4,4,4,4,4,4,},
 					{4,1,2,2,2,2,2,2,2,2,2,2,2,4,},
 					{4,1,16,2,16,2,16,2,16,2,16,2,2,4,},
 					{4,1,4,4,4,4,4,4,4,4,4,2,2,4,},
 					{4,1,4,1,32,2,16,2,1,1,16,32,4,4,},
 					{4,1,4,2,16,2,16,2,32,1,16,8,4,128,},
					{4,1,4,1,2,2,16,2,1,1,16,16,4,128,},
					{4,1,4,4,4,4,4,4,4,4,4,1,4,128,},
					{4,1,2,2,2,2,2,2,2,2,2,2,4,128,},
 					{4,1,4,16,4,16,4,16,4,16,4,16,4,128},
 					{4,1,2,2,2,2,2,2,2,2,2,2,4,128},
 					{4,4,4,4,4,4,4,4,4,4,4,4,4,128,}
				};
				game = new Game(data.GetLength(0),data.GetLength(1));
				this.game.LoadMap(data,this,resources);
				this.ClientSize = new System.Drawing.Size((data.GetLength(1)*50), (data.GetLength(0)*50));	
			}
			private void map15(){
				int[,] data = new int[,]
				{
					{4,4,4,4,4,4,4,4,4,4,4,4,128,128,},
					{4,1,1,2,2,4,2,2,2,2,2,4,4,4,},
					{4,1,1,2,2,4,2,16,2,2,16,2,2,4,},
					{4,1,1,2,2,4,16,4,4,4,4,2,2,4,},
					{4,1,1,2,2,2,2,8,2,4,4,2,2,4,},
 					{4,1,1,2,2,4,2,4,2,2,16,2,4,4,},
 					{4,4,4,4,4,4,2,4,4,16,2,16,2,4,},
 					{128,128,4,2,16,2,2,16,2,16,2,16,2,4,},
 					{128,128,4,2,2,2,2,4,2,2,2,2,2,4,},
 					{128,128,4,4,4,4,4,4,4,4,4,4,4,4,}
				};
				game = new Game(data.GetLength(0),data.GetLength(1));
				this.game.LoadMap(data,this,resources);
				this.ClientSize = new System.Drawing.Size((data.GetLength(1)*50), (data.GetLength(0)*50));	
			}
			private void map16(){
				int[,] data = new int[,]
				{
					{128,128,128,128,128,128,128,4,4,4,4,128,128,128,},
 					{4,4,4,4,4,4,4,4,2,2,4,4,4,4,},
 					{4,2,2,2,4,4,1,1,1,1,1,2,2,4,},
 					{4,2,2,16,2,2,4,4,1,1,1,4,2,4,},
 					{4,4,2,2,16,2,2,4,4,4,2,4,2,4,},
 					{128,4,2,4,2,16,2,2,4,2,2,2,2,4,},
					{128,4,2,2,4,2,16,2,2,4,2,2,2,4,},
 					{128,4,2,2,2,4,2,16,2,2,4,2,2,4,},
 					{128,4,2,2,2,2,4,2,16,2,4,2,4,4,},
 					{128,4,4,4,4,2,2,4,2,16,2,2,4,128,},
 					{128,128,128,128,4,4,2,2,4,2,16,2,4,128,},
 					{128,128,128,128,128,4,4,8,4,2,2,2,4,128,},
 					{128,128,128,128,128,128,4,4,4,4,4,4,4,128,}
				};
				game = new Game(data.GetLength(0),data.GetLength(1));
				this.game.LoadMap(data,this,resources);
				this.ClientSize = new System.Drawing.Size((data.GetLength(1)*50), (data.GetLength(0)*50));
			}
			private void map17(){
				int[,] data = new int[,]
				{
					{4,4,4,4,128,128,128,128,128,128,4,4,4,4,},
					{4,1,1,4,4,4,4,4,4,4,4,1,1,4,},
 					{4,32,1,32,1,1,1,1,1,32,1,32,1,4,},
 					{4,2,16,2,16,2,16,2,16,2,16,2,16,4,},
 					{4,16,2,16,2,16,8,16,2,16,2,16,2,4,},
 					{4,2,16,2,16,2,16,2,16,2,16,2,16,4,},
 					{4,16,2,16,2,16,2,16,2,16,2,16,2,4,},
 					{4,1,32,1,32,1,1,1,1,1,32,1,32,4,},
 					{4,1,1,4,4,4,4,4,4,4,4,1,1,4,},
 					{4,4,4,4,128,128,128,128,128,128,4,4,4,4,}
				};
				game = new Game(data.GetLength(0),data.GetLength(1));
				this.game.LoadMap(data,this,resources);
				this.ClientSize = new System.Drawing.Size((data.GetLength(1)*50), (data.GetLength(0)*50));
			}
			private void map18(){
				int[,] data = new int[,]
				{
					{4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,},
 					{4,4,4,1,4,2,2,2,2,2,2,4,4,4,4,},
					{4,4,1,1,4,2,16,2,2,16,2,4,2,2,4,},
					{4,1,1,1,4,2,4,4,2,16,2,4,2,2,4,},
 					{4,1,1,1,1,1,2,2,4,16,16,2,2,2,4,},
 					{4,4,1,1,1,1,16,2,2,2,2,4,16,2,4,},
 					{4,4,4,4,2,4,4,4,4,4,4,4,2,2,4,},
 					{4,2,2,2,16,2,2,2,2,2,2,2,2,4,4,},
 					{4,2,2,16,2,4,2,2,16,4,2,16,2,4,4,},
 					{4,2,16,4,4,4,2,16,2,4,2,16,16,2,4,},
 					{4,2,2,2,8,4,2,2,4,4,2,2,2,2,4,},
 					{4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,}
				};
				game = new Game(data.GetLength(0),data.GetLength(1));
				this.game.LoadMap(data,this,resources);
				this.ClientSize = new System.Drawing.Size((data.GetLength(1)*50), (data.GetLength(0)*50));
			}
			private void map19(){
				int[,] data =new int[,]
				{
					{4,4,4,4,4,128,128,128,128,128,128,128,128,128,128,128,},
					{4,1,1,1,4,128,4,4,4,4,4,128,128,128,128,128,},
 					{4,1,1,1,4,4,4,2,2,2,4,128,128,128,128,128,},
 					{4,1,1,1,1,2,2,2,16,16,4,4,4,4,4,128,},
 					{4,1,1,1,1,2,2,4,2,2,4,2,2,2,4,4,},
 					{4,1,1,4,16,4,4,4,4,2,4,16,4,2,2,4,},
 					{4,4,2,16,2,2,4,2,2,2,2,2,16,16,2,4,},
 					{4,2,2,16,4,2,8,2,16,2,16,16,4,2,2,4,},
 					{4,2,16,2,16,2,16,2,4,2,2,2,16,2,4,4,},
 					{4,2,2,2,4,2,2,16,2,4,4,2,2,2,4,128,},
 					{4,4,4,4,4,4,2,2,2,4,4,4,4,4,4,128,},
 					{128,128,128,128,128,4,4,4,4,4,128,128,128,128,128,128,}
				};
				game = new Game(data.GetLength(0),data.GetLength(1));
				this.game.LoadMap(data,this,resources);
				this.ClientSize = new System.Drawing.Size((data.GetLength(1)*50), (data.GetLength(0)*50));
			}
			private void map20(){
				int[,] data = new int[,]
				{
					{128,128,128,128,128,128,128,4,4,4,4,4,4,4,4,},
 					{128,128,128,128,128,128,128,4,2,2,4,2,2,2,4,},
 					{128,4,4,4,4,4,4,4,2,16,16,1,1,1,4,},
					{128,4,2,2,2,2,2,2,2,2,4,1,1,1,4,},
 					{128,4,2,4,4,4,4,4,4,16,4,1,1,1,4,},
 					{4,4,2,4,2,2,2,2,2,2,4,1,1,1,4,},
 					{4,2,2,4,2,4,16,2,16,2,4,4,4,4,4,},
 					{4,2,4,2,16,2,16,2,16,2,4,128,128,128,128,},
 					{4,2,8,2,2,16,2,4,2,2,4,128,128,128,128,},
 					{4,4,4,4,4,16,2,16,16,2,4,128,128,128,128,},
 					{128,128,128,128,4,2,2,2,2,2,4,128,128,128,128,},
 					{128,128,128,128,4,4,4,4,4,4,4,128,128,128,128,}
				};
				game = new Game(data.GetLength(0),data.GetLength(1));
				this.game.LoadMap(data,this,resources);
				this.ClientSize = new System.Drawing.Size((data.GetLength(1)*50), (data.GetLength(0)*50));
			}
		void 选关ToolStripMenuItemClick(object sender, EventArgs e)
		{
			Sokoban.UI.SelectForm sf = new Sokoban.UI.SelectForm();
			sf.Show();
		}
		void 重新开始ToolStripMenuItemClick(object sender, EventArgs e)
		{
			z = z-1;
			this.Close();
			MainForm mf = new MainForm();
			mf.Show();
		}
		void 帮助ToolStripMenuItemClick(object sender, EventArgs e)
		{
			Sokoban.UI.HelpForm hf = new Sokoban.UI.HelpForm();
			hf.Show();
		}
		void 关于ToolStripMenuItemClick(object sender, EventArgs e)
		{
			Sokoban.UI.AboutForm af = new Sokoban.UI.AboutForm();
			af.Show();
		}
		void 退出ToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
			Sokoban.Program.sf.Close();
		}
			
	}
}
