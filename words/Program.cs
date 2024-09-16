namespace words
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<string> words = 
            [
                "apocalypse", "scream", "tiger", "millennial", "espionage", "extravagant",
                "apathy", "generous", "rose", "fascination", "revolution", "artificial",
                "strife", "discrepancy", "ordinary", "rage", "devotion", "imagination",
                "delirious", "excruciating", "grateful", "capacity", "marathon", "volcano",
                "trend", "domination", "dramatic", "peaceful", "organic", "page", "hope",
                "duck", "pope", "rope", "graceful", "divine", "elementary", "basic", "genius",
                "iconic", "reservation", "planetary", "momentary", "sacrament", "viral",
                "lame", "game", "digress", "duress", "instinct", "devolution", "panic", "pain",
                "gain", "strain", "domain", "remain", "cage", "rock", "luck", "train", "drain",
                "trash", "stash", "smash", "dose", "pose", "lose", "hose", "most", "dock",
                "amphibian", "stream", "resilient", "egregious", "fragrance", "romance",
                "observe", "deserve", "obscure", "tape", "extreme", "rain", "grape", "cape",
                "dart", "cart", "fair", "rude", "nice", "cruel", "love", "fade", "fast", "cast",
                "past", "last", "pass", "mass", "fake", "rake", "lake", "rows", "toes", "foes",
                "fog", "dog", "log", "hog", "lazy", "hazy", "ironic", "moronic", "magic",
                "logic", "logos", "foggy", "fun", "pun", "fur", "gun", "run", "rug", "tug",
                "life", "stress", "mess", "mind", "find", "freak", "leak", "race", "lace", "face",
                "fact", "pact", "gaze", "maze", "lean", "cream", "dream", "steam", "information",
                "cry", "shy", "try", "why", "toys", "boy", "goat", "way", "mean", "fry", "tale",
                "spider", "emotion", "intense", "danger", "defense", "offense", "stranger", "sky",
                "ranger", "static", "stain",  "stormy", "polite", "police", "glare", "delegation",
                "stage", "bubonic", "crate", "cake", "case", "pace", "late", "fate", "mash",
                "date", "night", "gate", "mate", "cat", "rat", "fat", "mat", "map", "rest",
                "pest", "nest", "best", "test", "pear", "tear", "gear", "fear", "near", "rear",
                "dear", "beer", "bean", "bash", "star", "stay", "day", "ray", "cringe", "fringe",
                "prince", "quince", "robot", "cobra", "snake", "stake", "stand", "grand",
                "brand", "land", "band", "bear", "rare", "dare", "war", "wild", "waste", "taste",
                "paste", "grave", "wax", "fax", "boat", "water", "rated", "year", "cash", "crash",
                "fox", "box", "mop", "man", "tan", "fan", "gin", "girl", "live", "dive", "sting",
                "smear", "ride", "trade", "maid", "hide", "fellow", "glide", "fountain", "steer",
                "mountain", "money", "honey", "mad", "fad", "glad", "sad", "bad", "lad", "bid",
                "bin", "bat", "hat", "win", "wit", "bit", "sit", "lit", "hit", "chance", "stance",
                "glance", "lord", "word", "loan", "wand", "sand", "wait", "slope", "hate", "fly",
                "roar", "beat", "feet", "legit", "heat", "neat", "seat", "follow", "need", "seed",
                "mellow", "beet", "deer", "bent", "rent", "tent", "went", "instigate", "lizard",
                "feed", "weep", "when", "treat", "seal", "hollow", "cheat", "device", "distorted",
                "mice", "mug", "house", "ram", "jam", "rice", "dice", "regress", "impress",
                "repress", "brain", "grain", "splash", "main", "rap", "gut", "hut", "nap", "hug",
                "bug", "sage", "mage", "wizard", "mouse", "say", "may", "hay", "lay", "fantastic",
                "bombastic", "drape", "propagation", "desecration", "superstition", "fungus",
                "emancipation", "obfuscate", "denigrate", "fame", "dame", "lam", "ham", "join",
                "coin", "meme", "vain", "vase", "baby", "wary", "many", "dent", "send", "farm",
                "harm", "warm", "cold", "fold", "bold", "sold", "mold", "moan", "foam", "drone",
                "long", "gong", "bong", "bone", "lone", "wall", "pearl", "base", "leap", "leaf",
                "blow", "flow", "glow", "slow", "slot", "hot", "bot", "got", "not", "lot", "mic",
                "prank", "frank", "crank", "lice", "pic", "trick", "lungs", "humus", "rip", "dip",
                "nip", "sip", "lip", "reformation", "restitution", "infiltrate", "oration",
                "illustrate", "erosion", "negation", "nut", "rot", "sun", "sin", "son", "bow",
                "moon", "soon", "loon", "foot", "loop", "goon", "swirl", "swift", "stiff",
                "lock", "mock", "suck", "buck", "funk", "sunk", "rank", "bank", "trans", "sniff",
                "phone", "stone", "tall", "hall", "gall", "ball", "balm", "palm", "fixation",
                "rotation", "clash", "brash", "sports", "shorts", "monument", "document", "sight",
                "passion", "regiment", "sentient", "cow", "west", "loin", "steep", "deep", "now",
                "reef", "beef", "low", "sow", "how", "tow", "row", "elation", "mansion",
                "pension", "meek", "spank", "thick", "tone", "zone", "lime", "like", "line",
                "light", "fight", "might", "right", "strength", "hold", "gold", "flat", "pale",
                "seek", "reek", "seen", "weed", "geek", "leek", "work", "warp", "wane", "mile",
                "tension", "nose", "vow", "fit", "slang", "rust", "dust", "must", "lust", "bust",
                "trunk", "trump", "trust", "truck", "leverage", "beverage", "book", "hook",
                "rook", "took", "look", "nook", "gook", "cook", "lend", "bend", "tend", "mend",
                "lens", "zen", "hen", "den", "dot", "yen", "cost", "lost", "host", "deal", "sweep",
                "feel", "reel", "stuck", "steel", "will", "wheel", "whiff", "flash", "formal",
                "knife", "white", "black", "crack", "stack", "smack", "shack", "slack", "sale",
                "harsh", "marsh", "first", "burst", "nurse", "curse", "purse", "feral", "hail",
                "normal", "nordic", "gnostic", "crane", "radiation", "humiliation", "slave",
                "trace", "blaze", "flame", "crave", "grade", "grass", "brass", "brave", "fuck",
                "mine", "mike", "mist", "gist", "list", "food", "mood", "hood", "good", "doom",
                "root", "loot", "loom", "zoom", "hoot", "boot", "boom", "bowl", "howl", "soul",
                "amazon", "just", "avalon", "rate", "bait", "reed", "space", "teen", "kill",
                "fill", "bill", "mill", "hill", "nail", "rail", "wail", "sail", "bail", "dean",
                "deaf", "quit", "spit", "slit", "slip", "slap", "keen", "peek", "peak", "sick",
                "wick", "lick", "beak", "queen", "queer", "seem", "seam", "zest", "part", "mart",
                "hard", "pot", "cot", "spear", "shear", "swear", "surge", "purge", "merge",
                "forge", "heal", "smart", "spring", "farce", "large", "lair", "liar", "tail",
                "gait", "fire", "wire", "pire", "tire", "tier", "least", "beast", "lease",
                "feast", "east", "next", "peel", "real", "pill", "verge", "blame", "blast",
                "bloom", "groom", "shirt", "flirt", "sneer", "clear", "sheer", "swim",
                "suit", "pool", "tool", "gust", "swing", "blare", "blade", "clean", "slide",
                "pride", "tribe", "pipe", "pine", "pint", "wine", "dine", "fine", "hint", "hind",
                "side", "wind", "dire", "high", "nigh", "sigh", "tint", "drop", "crop", "stop",
                "flop", "crow", "grow", "spot", "shot", "prop", "coat", "goal", "grip", "flip",
                "ship", "ruin", "skip", "drip", "neon", "lion", "crime", "spine", "shine", "pry",
                "swine", "slime", "poor", "gone", "done", "lane", "bane", "cane", "mane", "pane",
                "door", "sane", "pick", "sock", "hock", "node", "code", "load", "road", "toad",
                "soap", "soar", "soak", "soil", "boil", "coil", "jail", "pail", "toil", "foil",
                "toll", "mall", "fall", "call", "doll", "told", "wood", "wool", "fool", "cool",
                "sway", "pray", "flay", "shape", "vape", "gape", "slay", "tray", "play", "clay",
                "fest", "jest", "less", "crest", "press", "dress", "quest", "guest", "chess",
                "seer", "week", "force", "peal", "weal", "monk", "dunk", "junk", "fist", "milk",
                "silk", "folk", "talk", "walk", "speed", "green", "fleet", "greet", "dry",
            ];

            Console.WriteLine("        count : " + words.Count);

            if (words.Count != words.Distinct().Count())
                Console.Write("duplicates exist | ");
            else
                Console.Write("no duplicates | ");

            var duplicates = words
                            .GroupBy(a => a)
                            .Where(b => b.Count() > 1)
                            .Select(c => c.Key)
                            .ToList();

            if (duplicates.Count != 0)
            {
                Console.Write("+1: ");
                foreach (string s in duplicates)
                    Console.Write(s + " ");
            }
            else
            {
                Console.Write("list was empty");
            }

            Console.WriteLine();
        }
    }
}