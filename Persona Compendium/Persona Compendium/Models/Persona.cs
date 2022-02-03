using System;
using System.Collections.Generic;
using System.Text;

namespace Persona_Compendium.Models
{
    // Based on the model @ https://github.com/chinhodado/persona5_calculator

    public enum Arcana
    {
        Fool, Magician, Priestess, Empress, Emperor, Hierophant, Lovers, Chariot, Justice, Hermit,
        Fortune, Strength, Hanged, Death, Tower, Star, Moon, Sun, Judgement, Faith, Councillor, World
    }

    public class Persona
    {
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
        public int strength { get; set; }
        public int magic { get; set; }
        public int endurance { get; set; }
        public int agility { get; set; }
        public int luck { get; set; }

        public string physical { get; set; }
        public string gun { get; set; }
        public string fire { get; set; }
        public string ice { get; set; }
        public string electric { get; set; }
        public string wind { get; set; }
        public string psychic { get; set; }
        public string nuclear { get; set; }
        public string bless { get; set; }
        public string curse { get; set; }

        // for sorting purpose
        public int physicalValue { get; set; }
        public int gunValue { get; set; }
        public int fireValue { get; set; }
        public int iceValue { get; set; }
        public int electricValue { get; set; }
        public int windValue { get; set; }
        public int psychicValue { get; set; }
        public int nuclearValue { get; set; }
        public int blessValue { get; set; }
        public int curseValue { get; set; }
    }
}
