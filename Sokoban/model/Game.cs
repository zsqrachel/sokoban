/*
 * Created by SharpDevelop.
 * User: zsq
 * Date: 2018/12/20
 * Time: 10:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using Sokoban.model;
using System.Drawing;

namespace Sokoban.model
{
	/// <summary>
	/// Description of Game.
	/// </summary>
	public class Game
	{
		private GameElement[,] map;
		private int row;
		private int column;
		
		public Game(int row, int column)
		{
			this.map = new GameElement[row,column];
			this.row = row;
			this.column = column;
		}
		
		public void LoadMap(int[,] data,Form winform,System.ComponentModel.ComponentResourceManager resources){
			for(int i = 0;i<row;i++){
				for(int j = 0; j<column;j++){
					GameElement ge = GameElementFactory.getElement(data[i,j],resources,winform,i,j);
					ge.Game = this;
					map[i,j] = ge;
				}
			}
		}
		public void ReLoadMap(int[,] data,Form winform,System.ComponentModel.ComponentResourceManager resources){
			for(int i = 0;i < winform.Controls.Count; i++){
				Control c = winform.Controls[i];
				c.Dispose();
				winform.Controls.Remove(c);
			}
			LoadMap(data,winform,resources);
			
		}
		public PersonElement GetCurrentPerson(){
			for(int i = 0;i<row;i++){
				for(int j = 0; j <column; j++){
					GameElement ge = map[i,j];
					if(ge.GetType() == typeof(PersonElement)){
						return (PersonElement)ge;
				   	}
				}
			}
			return null;
		}
		
		public PersonInDestinitionElement GetCurrentPersonInCage(){
			for(int i = 0;i<row;i++){
				for(int j = 0; j <column; j++){
					GameElement ge = map[i,j];
					if(ge.GetType() == typeof(PersonInDestinitionElement)){
						return (PersonInDestinitionElement)ge;
				   	}
				}
			}
			return null;
		}
		public GameElement GetNeighbor(Direction direction){
			if(GetCurrentPerson() != null){
				PersonElement pe = GetCurrentPerson();
				return GetNeighbor(pe,direction);
			}else{
				PersonInDestinitionElement pe = GetCurrentPersonInCage();
				return GetNeighbor(pe,direction);
			}
		}
			
			public GameElement GetNeighbor(GameElement pe,Direction direction){
			Position pos = pe.CurrentPosition;
			switch(direction){
				case Direction.LEFT:
					return map[pos.Row,pos.column-1];
				case Direction.RIGHT:
					return map[pos.Row,pos.column+1];
				case Direction.UP:
					return map[pos.Row-1,pos.column];
				case Direction.DOWN:
					return map[pos.Row+1,pos.column];
			}
			return null;
		}
		public void SwapElement(GameElement first,GameElement second){
			map[first.CurrentPosition.Row,first.CurrentPosition.column] =second;
			map[second.CurrentPosition.Row,second.CurrentPosition.column] =first;
			
			Point firstLocation = first.Control.Location;
			Point secondLocation = second.Control.Location;
			
			first.Control.Location = secondLocation;
			second.Control.Location = firstLocation;
		}
		public void UpdateMap(GameElement ge){
			map[ge.CurrentPosition.Row,ge.CurrentPosition.column]=ge;
		}
		public bool CheckOver(){
			for(int i = 0; i < row; i++){
				for(int j = 0; j <column; j++){
					GameElement ge = map[i,j];
						if(ge.GetType() == typeof(BoxElement) || ge.GetType() == typeof(DestinitionElement)){
						   	return false; 	
						   
						}
					}
				}
			return true;
			}
		public bool Misjudgement(){
			int BeCount = 0;
			int DeCount = 0;
			int PeCount = 0;
			for(int i = 0;i<row;i++){
				for(int j = 0; j <column; j++){
					GameElement ge = map[i,j];
					if(ge.GetType() == typeof(BoxElement)){
						BeCount++;
					}else if(ge.GetType() == typeof(DestinitionElement)){
						DeCount++;
					}else if(ge.GetType() == typeof(PersonInDestinitionElement)){
						PeCount++;
					}
				}
			}
			if(BeCount == DeCount+PeCount){
				return true;
			}else{return false;}
		}
	}
}

