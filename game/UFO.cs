namespace game
{
    internal class UFO
    {
        private readonly string s0 =
    @"    |                                 |
    |       .-""^""-.                   |
    |      /_....._\                  |
    |  .-""`         `""-.              |
    | (  ooo  ooo  ooo  )             |
    |  '-.,_________,.-'              |
    |      |       |                  |
    |      |       |                  |
    |      |   0   |     ,---------.  |
    |      | --|-- | ___(" + " \u00A1aguante! ) |\n" +
    @"    |      |   |   |     `---------'  |
    |      |  / \  |                  |";

        private readonly string s1 =
    @"    |                                 |
    |       .-""^""-.                   |
    |      /_....._\                  |
    |  .-""`         `""-.              |
    | (  ooo  ooo  ooo  )             |
    |  '-.,_________,.-'              |
    |      |       |                  |
    |      |   0   |     ,---------.  |
    |      | --|-- | ___(" + " \u00A1cojones! ) |\n" +
    @"    |      |   |   |     `---------'  |
    |      |  / \  |                  |
    |      |       |                  |";
        private readonly string s2 =
    @"    |                                 |
    |       .-""^""-.                   |
    |      /_....._\                  |
    |  .-""`         `""-.              |
    | (  ooo  ooo  ooo  )             |
    |  '-.,_________,.-'              |
    |      |   0   |                  |
    |      | --|-- | \___,---------.  |
    |      |   |   |    (" + " \u00A1pendejo! ) |\n" +
    @"    |      |  / \  |     `---------'  |
    |      |       |                  |
    |                                 |";

        private readonly string s3 =
    @"    |                                 |
    |       .-""^""-.                   |
    |      /_....._\                  |
    |  .-""`         `""-.              |
    | (  ooo  ooo  ooo  )             |
    |  '-.,_________,.-'              |
    |      | --|-- |      ,--------.  |
    |      |   |   | \___/" + " \u00A1ap\u00FArate \\ |\n" +
    @"    |      |  / \  |     \ pelotudo!/ |
    |      |       |      `--------'  |
    |                                 |
    |                                 |";

        private readonly string s4 =
    @"    |                                 |
    |       .-""^""-.                   |
    |      /_....._\                  |
    |  .-""`         `""-.              |
    | (  ooo  ooo  ooo  )             |
    |  '-.,_________,.-'              |
    |      |   |   |\    ,---------.  | 
    |      |  / \  | \__/" + " \u00A1pi\u00E9nsala \\ |\n" +
    "    |      |       |    \\  imb\u00E9cil! / |\n" +
    @"    |                     `---------' |
    |                                 |
    |                                 |";
        private readonly string s5 =
    @"    |       .-""^""-.                   |
    |      /_....._\                  |
    |  .-""`         `""-.              |
    | (  ooo  ooo  ooo  ) __          |
    |  '-.,_________,.-'    \         |
    |      |  / \  |         \        |
    |      |       |     ,----^----.  |
    |                   /" + "\u00A1gilipollas\\ |\n" +
    @"    |                   \ de mierda!/ |
    |                    `---------'  |
    |                                 |
    |                                 |";
        private readonly string s6 =
    @"    |       .-""^""-.                   |
    |      /_..0.._\ ------,          |
    |  .-""`         `""-.    \         |
    | (  ooo  ooo  ooo  )    \        |
    |  '-.,_________,.-'      \       |
    |      |       |       ,---^---.  |
    |                     /" + "\u00A1con dos \\ |\n" +
    @"    |                     \ cojones!/ |
    |                      `-------'  |
    |                                 |
    |                                 |
    |                                 |";
        private readonly string s7 =
    @"    |       .-""^""-.                   |
    |      /_....._\                  |
    |  .-""`         `""-.              |
    | (  ooo  ooo  ooo  )             |
    |  '-.,_________,.-'              |
    |                                 |
    |                                 |
    |                                 |
    |                         _ 0     |
    |                        / |\_    |
    |                          |      |
    |                         / \     |";
        private readonly string[] ufos;
        private int stage;

        public UFO() => ufos = new string[] { s0, s1, s2, s3, s4, s5, s6, s7 };

        public void AddPart()
        {
            stage++;

            if (stage >= ufos.Length)
            {
                Console.WriteLine("staging error");
                stage = ufos.Length - 1;
                Console.ReadKey();
            }
        }

        public void SetFinal() => stage = ufos.Length - 1;
        public string Showcase() => ufos[stage];
        public override string ToString() => "I'm a UFO object...";
    }
}