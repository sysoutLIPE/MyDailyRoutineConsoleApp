using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDailyRoutineConsoleApp.Models
{
    public class SetOfDailyTasks
    {
        //Atributes
        private bool meditation { get; set; }
        private bool stretching { get; set; }
        private bool calisthenics { get; set; }
        private bool french { get; set; }
        private bool cSharpDotNet { get; set; }
        private bool sqlDatabase { get; set; }
        private bool java { get; set; }
        private bool extremeProgramming { get; set; }
        private bool softwareDesign { get; set; }
        private bool electronics { get; set; }

        //Methods

        public bool getMeditation()
        {
            return meditation;
        }
        public void setMeditation(bool meditation)
        {
            this.meditation = meditation;
        }

        public bool getStretching()
        {
            return stretching;
        }
        public void setStretching(bool stretching)
        {
            this.stretching = stretching;
        }

        public bool getCalisthenics()
        {
            return calisthenics;
        }
        public void setCalisthenics(bool calisthenics)
        {
            this.calisthenics = calisthenics;
        }

        public bool getFrench()
        {
            return french;
        }
        public void setFrench(bool french)
        {
            this.french = french;
        }

        public bool getCsharpDotNet()
        {
            return cSharpDotNet;
        }
        public void setCsharpDotNet(bool cSharpDotNet)
        {
            this.cSharpDotNet = cSharpDotNet;
        }

        public bool getSqlDatabase()
        {
            return sqlDatabase;
        }
        public void setSqlDatabase(bool sqlDatabase)
        {
            this.sqlDatabase = sqlDatabase;
        }

        public bool getJava()
        {
            return java;
        }
        public void setJava(bool java)
        {
            this.java = java;
        }

        public bool getExtremeProgramming()
        {
            return extremeProgramming;
        }
        public void setExtremeProgramming(bool extremeProgramming)
        {
            this.extremeProgramming = extremeProgramming;
        }

        public bool getSoftwareDesign()
        {
            return softwareDesign;
        }
        public void setSoftwareDesign(bool softwareDesign)
        {
            this.softwareDesign = softwareDesign;
        }

        public bool getElectronics()
        {
            return electronics;
        }
        public void setElectronics(bool electronics)
        {
            this.electronics = electronics;
        }

        

















    }
}