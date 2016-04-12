using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charply.Classes
{
    abstract class PlayerObject
    {
        #region Attributes
        private Position pos;
        private double life;
        private string name;
        private string direction;
        private string info;
        private LinkedList<Skill> skills;
        #endregion

        #region Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Position Pos
        {
            get { return pos; }
            set { pos = value; }
        }
        public LinkedList<Skill> Skills
        {
            get { return skills; }
            set { skills = value; }
        }
        #endregion

        #region Constructors
        public PlayerObject(string name, double life, LinkedList<Skill> skilllist)
        {
            this.pos = new Position(0,0);
            this.life = life;
            this.name = name;
            this.direction = "N";
            this.info = "";
            this.skills = new LinkedList<Skill>();
        }
        public PlayerObject(PlayerObject po, Position position)
        {
            this.pos = position;
            this.life = po.life;
            this.name = po.name;
            this.direction = po.direction;
            this.info = po.info;
            this.skills = po.skills;
        }
        #endregion

        #region Functions
        #endregion
    }
}
