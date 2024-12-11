using HSLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSLibrary.Models.Dinghy
{
    public class Dinghy
    {
        public int Id { get; }
        private static int _count = 0;
        public DinghyModel Model { get; }
        public string Components { get; }
        public bool NeedsRepair
        {
            get
            {
                return RepairComment == null;
            }
        }
        public string RepairComment { get; private set; }
        public List<RepairLogEntry> RepairLog;

        public Dinghy(DinghyModel model, string components)
        {
            Id = _count++;
            Model = model;
            Components = components;
            RepairLog = new List<RepairLogEntry>();
        }
        public void RepairDinghy(string notes)
        {
            RepairLog.Add(new RepairLogEntry(notes));
            RepairComment = null;
        }
        public void Repair(string repairComment)
        {
            RepairComment = repairComment;
        }
        public override string ToString()
        {
            return $"ID: {Id} | Model: {Model} | Komponenter: {Components}";
        }
    }
}
