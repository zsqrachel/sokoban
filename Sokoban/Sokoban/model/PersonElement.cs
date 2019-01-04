/*
 * Created by SharpDevelop.
 * User: win10
 * Date: 2018/12/17
 * Time: 21:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Collections;
using Sokoban.model;
using System.Drawing;
using System.ComponentModel;

namespace Sokoban.model
{
	
	/// <summary>
	/// Description of PersonElement.
	/// </summary>
	public class PersonElement:GameElement
	{
		public static int s = 0;
		public PersonElement():base(8)
		{
		}
		public override void MoveInForm(System.Windows.Forms.Form winForm,Direction direction,System.ComponentModel.ComponentResourceManager resources)
		{
			s++;
			bool result = CanMove(direction);
			if(!result) return;
			PictureBox pbx = this.Control;
			Point oldLocation = pbx.Location;
			Point newPoint = Point.Empty;
			Position oldPosition = this.CurrentPosition;
		
		
			GameElement ge = this.Game.GetNeighbor(direction);
			if(ge.GetType()==typeof(EmptyElement)){
				this.Game.SwapElement(this,ge);
				ge.Game = this.Game;
				Turn(direction,resources);
			}else if(ge.GetType() == typeof(BoxElement)){
				ge.MoveInForm(winForm,direction,resources);
				ge = this.Game.GetNeighbor(direction);
				this.Game.SwapElement(this,ge);
				ge.Game = this.Game;
				Turn(direction,resources);
			}else if(ge.GetType() == typeof(DestinitionElement)){
				EmptyElement ee = new EmptyElement();
				ee.Control = ge.Control;
				ee.Control.BackgroundImage = null;
				ee.Game = this.Game;
				this.Game.UpdateMap(ee);
				
				PersonInDestinitionElement pe = new PersonInDestinitionElement();
				pe.Control = this.Control;
//				pe.Control.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.wolf.cage.down")));
				pe.Turn(direction,resources);
				pe.Game = this.Game;
				this.Game.UpdateMap(pe);
			}else if(ge.GetType() == typeof(BoxInDestinitionElement)){
				ge.MoveInForm(winForm,direction,resources);
				ge = this.Game.GetNeighbor(direction);
				ge.Game = this.Game;
				this.Game.UpdateMap(ge);
				
				EmptyElement ee = new EmptyElement();
				ee.Control = ge.Control;
				ee.Control.BackgroundImage = null;
				ee.Game = this.Game;
				this.Game.UpdateMap(ee);
				
				PersonInDestinitionElement pe = new PersonInDestinitionElement();
				pe.Control = this.Control;
//				pe.Control.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.wolf.cage.down")));
				pe.Turn(direction,resources);
				pe.Game = this.Game;
				this.Game.UpdateMap(pe);
			}
			
			this.Control.BringToFront();	
			
			if(ge.GetType()==typeof(DestinitionElement)){
				ge.MoveInForm(winForm,direction,resources);
				ge.Game = this.Game;
				ge = this.Game.GetNeighbor(direction);
				
				EmptyElement ee = new EmptyElement();
				ee.Control = this.Control;
				ee.Control.BackgroundImage = null;
				ee.Game = this.Game;
				this.Game.UpdateMap(ee);
				
				PersonInDestinitionElement pe = new PersonInDestinitionElement();
				pe.Control = ge.Control;
//				pe.Control.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.wolf.cage.down")));
				pe.Turn(direction,resources);
				pe.Game = this.Game;
				this.Game.UpdateMap(pe);
			}
			
			if(this.Game.CheckOver()){
//				MessageBox.Show("不是一个人的王者，而是团队的荣耀！");
				string count = s+"";
				MessageBox.Show("您的步数为"+count+",恭喜进入下一关!");
//				MainForm mf = (MainForm)winForm;
//				mf.map2();
				MainForm mf = new MainForm();

				mf.Show();
				winForm.Close();
			}
//			switch(direction){
//				case Direction.LEFT:
//					newPoint = new Point(oldLocation.X-50,oldLocation.Y);
//					//this.CurrentPosition = new Position(oldPosition.Row,oldPosition.column-1);
//					pbx.Location = newPoint;
//					this.Control.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.wolf.left")));
//					break;
//				case Direction.RIGHT:
//					newPoint = new Point(oldLocation.X+50,oldLocation.Y);
//					//this.CurrentPosition = new Position(oldPosition.Row,oldPosition.column+1);
//					pbx.Location = newPoint;
//					this.Control.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.wolf.right")));
//					break;
//				case Direction.UP:
//					newPoint = new Point(oldLocation.X,oldLocation.Y-50);
//					//this.CurrentPosition = new Position(oldPosition.Row-1,oldPosition.column);
//					pbx.Location = newPoint;
//					this.Control.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.wolf.up")));
//					break;
//				case Direction.DOWN:
//					newPoint = new Point(oldLocation.X,oldLocation.Y+50);
//					//this.CurrentPosition = new Position(oldPosition.Row+1,oldPosition.column);
//					pbx.Location = newPoint;
//					this.Control.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.wolf.down")));
//					break;
			}
		
		public override bool CanMove(Direction direction)
		{
			bool pass = true;
			switch(direction){
				case Direction.UP:
					pass = !(this.CurrentPosition.Row<0);
					break;
				case Direction.DOWN:
					pass = !(this.CurrentPosition.Row>10);
					break;
				case Direction.LEFT:
					pass = !(this.CurrentPosition.column<0);
					break;
				case Direction.RIGHT:
					pass = !(this.CurrentPosition.column>14);
					break;
			}
			GameElement ge = this.Game.GetNeighbor(direction);
			if(ge.GetType() == typeof(WallElement)){
			   pass = false;
			}else if(ge.GetType() == typeof(BoxElement)){
				pass = ge.CanMove(direction);
			}else if(ge.GetType() ==typeof(BoxInDestinitionElement)){
				pass = ge.CanMove(direction);
			}
			return pass;
		}
		
		public void Turn(Direction direction,System.ComponentModel.ComponentResourceManager resources){
			switch(direction){
				case Direction.LEFT:
					this.Control.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.wolf.left")));
					break;
				case Direction.RIGHT:
					this.Control.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.wolf.right")));
					break;
				case Direction.UP:
					this.Control.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.wolf.up")));
					break;
				case Direction.DOWN:
					this.Control.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.wolf.down")));
					break;

			}		
		}
	}	
}
