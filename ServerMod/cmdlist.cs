﻿using ServerMod.cmds;
using System.Collections.Generic;

namespace ServerMod
{
    class cmdlist
    {
        private List<cmd> cmds = new List<cmd>();

        public cmdlist()
        {
            cmds.Add(new AutoCMD());
            cmds.Add(new AutoSpecCMD());
            cmds.Add(new CountdownCMD());
            cmds.Add(new DelCMD());
            cmds.Add(new ForceStartCMD());
            cmds.Add(new HelpCMD());
            cmds.Add(new LevelCMD());
            cmds.Add(new ListCMD());
            cmds.Add(new NameCMD());
            cmds.Add(new PlayCMD());
            cmds.Add(new PlaylistCMD());
            cmds.Add(new ScoresCMD());
            cmds.Add(new ServerCMD());
            cmds.Add(new ShuffleCMD());
            cmds.Add(new SpecCMD());
        }

        public cmd getCommand(string name)
        {
            if (name.Length == 0)
                return null;
            if (name.StartsWith("!"))
                name = name.Substring(1);
            name = name.ToLower();

            foreach(cmd c in cmds)
                if (c.name.Equals(name))
                    return c;
            return null;
        }

        public List<string> commands()
        {
            List<string> l = new List<string>();
            foreach(var c in cmds)
                l.Add(c.name);
            return l;
        }
    }
}