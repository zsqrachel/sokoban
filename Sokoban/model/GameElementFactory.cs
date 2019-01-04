/*
 * Created by SharpDevelop.
 * User: zsq
 * Date: 2018/12/19
 * Time: 10:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using Sokoban.model;

namespace Sokoban.model
{
	/// <summary>
	/// Description of GameElementFactory.
	/// </summary>
	public class GameElementFactory
	{
		public GameElementFactory()
		{
		}
		public static GameElement getElement(int type,System.ComponentModel.ComponentResourceManager resources,Form winform,int row,int column)
		{
			PictureBox pbx = new PictureBox();
			pbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			pbx.Size = new Size(new Point(50,50));
			//element.CurrentPosition = new Sokoban.model.Position(1,1);
			switch(type){
				case 1:
					DestinitionElement de = new DestinitionElement();
					pbx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.cage")));
					pbx.Location = new Point(column*50,row*50);
					de.Control = pbx;
					de.ShowInForm(winform);
					return de;
				case 2:
					EmptyElement emp = new EmptyElement();
					pbx.Location = new Point(column*50,row*50);
					emp.Control = pbx;
					emp.ShowInForm(winform);
					return emp;
				case 4:
					WallElement wall = new WallElement();
					pbx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.tree")));
					pbx.Location = new Point(column*50,row*50);
					wall.Control = pbx;
					wall.ShowInForm(winform);
					return wall;
				case 8:
					PersonElement per = new PersonElement();
					pbx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.wolf.down")));
					pbx.Location = new Point(column*50,row*50);
					per.Control = pbx;
					per.ShowInForm(winform);
					return per;
				case 16:
					BoxElement box = new BoxElement();
					pbx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.sheep")));
					pbx.Location = new Point(column*50,row*50);
					box.Control = pbx;
					box.ShowInForm(winform);
					return box;
				case 32:
					BoxInDestinitionElement bid = new BoxInDestinitionElement();
					pbx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.sheep.cage")));
					pbx.Location = new Point(column*50,row*50);
					bid.Control = pbx;
					bid.ShowInForm(winform);
					return bid;
				case 64:
					PersonInDestinitionElement pid = new PersonInDestinitionElement();
					pbx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.wolf.cage.down")));
					pbx.Location = new Point(column*50,row*50);
					pid.Control = pbx;
					pid.ShowInForm(winform);
					return pid;
				case 128:
					NothingElement not = new NothingElement();
					pbx.BackColor = Color.Black;
					pbx.Location = new Point(column*50,row*50);
					not.Control = pbx;
					not.ShowInForm(winform);
					return not;
					default: return null;
			}
		}
	}
}
