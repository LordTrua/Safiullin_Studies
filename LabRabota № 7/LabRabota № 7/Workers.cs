using System;
using System.Collections.Generic;
using System.Text;

namespace LabRabota___7
{
    class Workers
    {
        private int id;
        public string FIO;
        private int id_o = 0;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="i">ID</param>
        /// <param name="f">Familia</param>
        /// <param name="io">Department ID</param>
        public Workers(int i, string f)
        {
            id = i;
            FIO = f;
        }
        /// <summary>
        /// Чтение Id
        /// </summary>
        /// <returns></returns>
        public int get_id() { return this.id; } 
        /// <summary>
        /// Чтение Id отдела
        /// </summary>
        /// <returns></returns>
        public int get_id_o() { return this.id_o; }
        /// <summary>
        /// Чтение FIO
        /// </summary>
        /// <returns></returns>
        public string get_FIO() { return this.FIO; }
        /// <summary>
        /// смена отлела
        /// </summary>
        /// <param name="o">ID отела</param>
        public void set_id_o(int o) { this.id_o = o; }

        public string cout ()
        {
            if (this.id < 10) return "ID: " + this.get_id() + "   FIO: " + this.get_FIO() + "  ID_O:  " + this.get_id_o();
            else return "ID: " + this.get_id() + " FIO: " + this.get_FIO() + "  ID_O:  " + this.get_id_o();
        }
    }
}
