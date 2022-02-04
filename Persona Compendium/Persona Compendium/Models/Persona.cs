using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persona_Compendium.Models
{
    // Based on the model @ https://github.com/chinhodado/persona5_calculator

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Arcana
    {
        Unset, Fool, Magician, Priestess, Empress, Emperor, Hierophant, Lovers, Chariot, Justice, Hermit, Devil,
        Fortune, Strength, Hanged, Death, Tower, Star, Moon, Sun, Judgement, Faith, Councillor, World, Temperance
    }

    public class Persona
    {
        internal Dictionary<string, int> ResistanceMap = new Dictionary<string, int>()
        {
            { "wk", 0 }, { "-", 1 }, { "rs", 2 },
            { "nu", 3 }, { "rp", 4 }, { "ab", 5}
        };

        public string name { get; set; }
        public Arcana arcana { get; set; }
        public uint level { get; set; }
        public int[] stats { get; set; }
        public string[] elems { get; set; }
        public IDictionary<string, uint> skills { get; set; }
        public string personality { get; set; }
        public bool special { get; set; }
        public bool max { get; set; }
        public bool dlc { get; set; }
        public string note { get; set; }
        public bool rare { get; set; }

        // from new data for p5r
        public string inherits { get; set; }
        public string item { get; set; }
        public string itemr { get; set; }
        public string trait { get; set; }

        // only for when converted to list
        public int strength { get { return stats[0]; } set { stats[0] = value; } }
        public int magic { get { return stats[1]; } set { stats[1] = value; } }
        public int endurance { get { return stats[2]; } set { stats[2] = value; } }
        public int agility { get { return stats[3]; } set { stats[3] = value; } }
        public int luck { get { return stats[4]; } set { stats[4] = value; } }

        public string physical { get { return elems[0]; } set { elems[0] = value; } }
        public string gun { get { return elems[1]; } set { elems[1] = value; } }
        public string fire { get { return elems[2]; } set { elems[2] = value; } }
        public string ice { get { return elems[3]; } set { elems[3] = value; } }
        public string electric { get { return elems[4]; } set { elems[4] = value; } }
        public string wind { get { return elems[5]; } set { elems[5] = value; } }
        public string psychic { get { return elems[6]; } set { elems[6] = value; } }
        public string nuclear { get { return elems[7]; } set { elems[7] = value; } }
        public string bless { get { return elems[8]; } set { elems[8] = value; } }
        public string curse { get { return elems[9]; } set { elems[9] = value; } }

        // for sorting purpose
        public int physicalValue { get { return ResistanceMap[physical]; } }
        public int gunValue { get { return ResistanceMap[gun]; } }
        public int fireValue { get { return ResistanceMap[fire]; } }
        public int iceValue { get { return ResistanceMap[ice]; } }
        public int electricValue { get { return ResistanceMap[electric]; } }
        public int windValue { get { return ResistanceMap[wind]; } }
        public int psychicValue { get { return ResistanceMap[psychic]; } }
        public int nuclearValue { get { return ResistanceMap[nuclear]; } }
        public int blessValue { get { return ResistanceMap[bless]; } }
        public int curseValue { get { return ResistanceMap[curse]; } }
    }
}
