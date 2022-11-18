﻿using PKHeX.Core;
using System;
using System.Collections.Generic;


namespace WangPluginPkm.SortBase
{
    internal class Gen9__Paldea : SortingBase
    {
        private static readonly Dictionary<Species, int> dex = new Dictionary<Species, int>()
        {
            /*  {Species.Sprigatito, 1},
                {Species.Floragato, 2},
                {Species.Meowscarada, 3},
                {Species.Fuecoco, 4},
                {Species.Crocalor, 5},
                {Species.Skeledirge, 6},
                {Species.Quaxly, 7},
                {Species.Quaxwell, 8},
                {Species.Quaquaval, 9},
                {Species.Lechonk, 10},
                {Species.Oinkologne, 11},
                {Species.Tarountula, 12},
                {Species.Spidops, 13},
                {Species.Nymble, 14},
                {Species.Lokix, 15},
                {Species.Hoppip, 16},
                {Species.Skiploom, 17},
                {Species.Jumpluff, 18},
                {Species.Fletchling, 19},
                {Species.Fletchinder, 20},
                {Species.Talonflame, 21},
                {Species.Pawmi, 22},
                {Species.Pawmo, 23},
                {Species.Pawmot, 24},
                {Species.Houndour, 25},
                {Species.Houndoom, 26},
                {Species.Tranquill, 27},
                {Species.Unfezant, 28},
                {Species.Nickit, 29},
                {Species.Thievul, 30},
                {Species.Zigzagoon, 31},
                {Species.Linoone, 32},
                {Species.Obstagoon, 33},
                {Species.Wooloo, 34},
                {Species.Dubwool, 35},
                {Species.Lotad, 36},
                {Species.Lombre, 37},
                {Species.Ludicolo, 38},
                {Species.Seedot, 39},
                {Species.Nuzleaf, 40},
                {Species.Shiftry, 41},
                {Species.Chewtle, 42},
                {Species.Drednaw, 43},
                {Species.Purrloin, 44},
                {Species.Liepard, 45},
                {Species.Yamper, 46},
                {Species.Boltund, 47},
                {Species.Bunnelby, 48},
                {Species.Diggersby, 49},
                {Species.Minccino, 50},
                {Species.Cinccino, 51},
                {Species.Bounsweet, 52},
                {Species.Steenee, 53},
                {Species.Tsareena, 54},
                {Species.Oddish, 55},
                {Species.Gloom, 56},
                {Species.Vileplume, 57},
                {Species.Bellossom, 58},
                {Species.Budew, 59},
                {Species.Roselia, 60},
                {Species.Roserade, 61},
                {Species.Wingull, 62},
                {Species.Pelipper, 63},
                {Species.Joltik, 64},
                {Species.Galvantula, 65},
                {Species.Electrike, 66},
                {Species.Manectric, 67},
                {Species.Vulpix, 68},
                {Species.Ninetales, 69},
                {Species.Growlithe, 70},
                {Species.Arcanine, 71},
                {Species.Vanillite, 72},
                {Species.Vanillish, 73},
                {Species.Vanilluxe, 74},
                {Species.Swinub, 75},
                {Species.Piloswine, 76},
                {Species.Mamoswine, 77},
                {Species.Delibird, 78},
                {Species.Snorunt, 79},
                {Species.Glalie, 80},
                {Species.Froslass, 81},
                {Species.Baltoy, 82},
                {Species.Claydol, 83},
                {Species.Mudbray, 84},
                {Species.Mudsdale, 85},
                {Species.Dwebble, 86},
                {Species.Crustle, 87},
                {Species.Golett, 88},
                {Species.Golurk, 89},
                {Species.Munna, 90},
                {Species.Musharna, 91},
                {Species.Natu, 92},
                {Species.Xatu, 93},
                {Species.Stufful, 94},
                {Species.Bewear, 95},
                {Species.Snover, 96},
                {Species.Abomasnow, 97},
                {Species.Krabby, 98},
                {Species.Kingler, 99},
                {Species.Wooper, 100},
                {Species.Quagsire, 101},
                {Species.Corphish, 102},
                {Species.Crawdaunt, 103},
                {Species.Nincada, 104},
                {Species.Ninjask, 105},
                {Species.Shedinja, 106},
                {Species.Tyrogue, 107},
                {Species.Hitmonlee, 108},
                {Species.Hitmonchan, 109},
                {Species.Hitmontop, 110},
                {Species.Pancham, 111},
                {Species.Pangoro, 112},
                {Species.Klink, 113},
                {Species.Klang, 114},
                {Species.Klinklang, 115},
                {Species.Combee, 116},
                {Species.Vespiquen, 117},
                {Species.Bronzor, 118},
                {Species.Bronzong, 119},
                {Species.Ralts, 120},
                {Species.Kirlia, 121},
                {Species.Gardevoir, 122},
                {Species.Gallade, 123},
                {Species.Drifloon, 124},
                {Species.Drifblim, 125},
                {Species.Gossifleur, 126},
                {Species.Eldegoss, 127},
                {Species.Cherubi, 128},
                {Species.Cherrim, 129},
                {Species.Stunky, 130},
                {Species.Skuntank, 131},
                {Species.Tympole, 132},
                {Species.Palpitoad, 133},
                {Species.Seismitoad, 134},
                {Species.Duskull, 135},
                {Species.Dusclops, 136},
                {Species.Dusknoir, 137},
                {Species.Machop, 138},
                {Species.Machoke, 139},
                {Species.Machamp, 140},
                {Species.Gastly, 141},
                {Species.Haunter, 142},
                {Species.Gengar, 143},
                {Species.Magikarp, 144},
                {Species.Gyarados, 145},
                {Species.Goldeen, 146},
                {Species.Seaking, 147},
                {Species.Remoraid, 148},
                {Species.Octillery, 149},
                {Species.Shellder, 150},
                {Species.Cloyster, 151},
                {Species.Feebas, 152},
                {Species.Milotic, 153},
                {Species.Basculin, 154},
                {Species.Wishiwashi, 155},
                {Species.Pyukumuku, 156},
                {Species.Trubbish, 157},
                {Species.Garbodor, 158},
                {Species.Sizzlipede, 159},
                {Species.Centiskorch, 160},
                {Species.Rolycoly, 161},
                {Species.Carkol, 162},
                {Species.Coalossal, 163},
                {Species.Diglett, 164},
                {Species.Dugtrio, 165},
                {Species.Drilbur, 166},
                {Species.Excadrill, 167},
                {Species.Roggenrola, 168},
                {Species.Boldore, 169},
                {Species.Gigalith, 170},
                {Species.Timburr, 171},
                {Species.Gurdurr, 172},
                {Species.Conkeldurr, 173},
                {Species.Woobat, 174},
                {Species.Swoobat, 175},
                {Species.Noibat, 176},
                {Species.Noivern, 177},
                {Species.Onix, 178},
                {Species.Steelix, 179},
                {Species.Arrokuda, 180},
                {Species.Barraskewda, 181},
                {Species.Meowth, 182},
                {Species.Perrserker, 183},
                {Species.Persian, 184},
                {Species.Milcery, 185},
                {Species.Alcremie, 186},
                {Species.Cutiefly, 187},
                {Species.Ribombee, 188},
                {Species.Ferroseed, 189},
                {Species.Ferrothorn, 190},
                {Species.Pumpkaboo, 191},
                {Species.Gourgeist, 192},
                {Species.Pichu, 193},
                {Species.Pikachu, 194},
                {Species.Raichu, 195},
                {Species.Eevee, 196},
                {Species.Vaporeon, 197},
                {Species.Jolteon, 198},
                {Species.Flareon, 199},
                {Species.Espeon, 200},
                {Species.Umbreon, 201},
                {Species.Leafeon, 202},
                {Species.Glaceon, 203},
                {Species.Sylveon, 204},
                {Species.Applin, 205},
                {Species.Flapple, 206},
                {Species.Appletun, 207},
                {Species.Espurr, 208},
                {Species.Meowstic, 209},
                {Species.Swirlix, 210},
                {Species.Slurpuff, 211},
                {Species.Spritzee, 212},
                {Species.Aromatisse, 213},
                {Species.Dewpider, 214},
                {Species.Araquanid, 215},
                {Species.Wynaut, 216},
                {Species.Wobbuffet, 217},
                {Species.Farfetchd, 218},
                {Species.Sirfetchd, 219},
                {Species.Chinchou, 220},
                {Species.Lanturn, 221},
                {Species.Croagunk, 222},
                {Species.Toxicroak, 223},
                {Species.Scraggy, 224},
                {Species.Scrafty, 225},
                {Species.Stunfisk, 226},
                {Species.Shuckle, 227},
                {Species.Barboach, 228},
                {Species.Whiscash, 229},
                {Species.Shellos, 230},
                {Species.Gastrodon, 231},
                {Species.Wimpod, 232},
                {Species.Golisopod, 233},
                {Species.Binacle, 234},
                {Species.Barbaracle, 235},
                {Species.Corsola, 236},
                {Species.Cursola, 237},
                {Species.Impidimp, 238},
                {Species.Morgrem, 239},
                {Species.Grimmsnarl, 240},
                {Species.Hatenna, 241},
                {Species.Hattrem, 242},
                {Species.Hatterene, 243},
                {Species.Salandit, 244},
                {Species.Salazzle, 245},
                {Species.Pawniard, 246},
                {Species.Bisharp, 247},
                {Species.Throh, 248},
                {Species.Sawk, 249},
                {Species.Koffing, 250},
                {Species.Weezing, 251},
                {Species.Bonsly, 252},
                {Species.Sudowoodo, 253},
                {Species.Cleffa, 254},
                {Species.Clefairy, 255},
                {Species.Clefable, 256},
                {Species.Togepi, 257},
                {Species.Togetic, 258},
                {Species.Togekiss, 259},
                {Species.Munchlax, 260},
                {Species.Snorlax, 261},
                {Species.Cottonee, 262},
                {Species.Whimsicott, 263},
                {Species.Rhyhorn, 264},
                {Species.Rhydon, 265},
                {Species.Rhyperior, 266},
                {Species.Gothita, 267},
                {Species.Gothorita, 268},
                {Species.Gothitelle, 269},
                {Species.Solosis, 270},
                {Species.Duosion, 271},
                {Species.Reuniclus, 272},
                {Species.Karrablast, 273},
                {Species.Escavalier, 274},
                {Species.Shelmet, 275},
                {Species.Accelgor, 276},
                {Species.Elgyem, 277},
                {Species.Beheeyem, 278},
                {Species.Cubchoo, 279},
                {Species.Beartic, 280},
                {Species.Rufflet, 281},
                {Species.Braviary, 282},
                {Species.Vullaby, 283},
                {Species.Mandibuzz, 284},
                {Species.Skorupi, 285},
                {Species.Drapion, 286},
                {Species.Litwick, 287},
                {Species.Lampent, 288},
                {Species.Chandelure, 289},
                {Species.Inkay, 290},
                {Species.Malamar, 291},
                {Species.Sneasel, 292},
                {Species.Weavile, 293},
                {Species.Sableye, 294},
                {Species.Mawile, 295},
                {Species.Maractus, 296},
                {Species.Sigilyph, 297},
                {Species.Riolu, 298},
                {Species.Lucario, 299},
                {Species.Torkoal, 300},
                {Species.Mimikyu, 301},
                {Species.Cufant, 302},
                {Species.Copperajah, 303},
                {Species.Qwilfish, 304},
                {Species.Frillish, 305},
                {Species.Jellicent, 306},
                {Species.Mareanie, 307},
                {Species.Toxapex, 308},
                {Species.Cramorant, 309},
                {Species.Toxel, 310},
                {Species.Toxtricity, 311},
                {Species.Silicobra, 312},
                {Species.Sandaconda, 313},
                {Species.Hippopotas, 314},
                {Species.Hippowdon, 315},
                {Species.Durant, 316},
                {Species.Heatmor, 317},
                {Species.Helioptile, 318},
                {Species.Heliolisk, 319},
                {Species.Hawlucha, 320},
                {Species.Trapinch, 321},
                {Species.Vibrava, 322},
                {Species.Flygon, 323},
                {Species.Axew, 324},
                {Species.Fraxure, 325},
                {Species.Haxorus, 326},
                {Species.Yamask, 327},
                {Species.Runerigus, 328},
                {Species.Cofagrigus, 329},
                {Species.Honedge, 330},
                {Species.Doublade, 331},
                {Species.Aegislash, 332},
                {Species.Ponyta, 333},
                {Species.Rapidash, 334},
                {Species.Sinistea, 335},
                {Species.Polteageist, 336},
                {Species.Indeedee, 337},
                {Species.Phantump, 338},
                {Species.Trevenant, 339},
                {Species.Morelull, 340},
                {Species.Shiinotic, 341},
                {Species.Oranguru, 342},
                {Species.Passimian, 343},
                {Species.Morpeko, 344},
                {Species.Falinks, 345},
                {Species.Drampa, 346},
                {Species.Turtonator, 347},
                {Species.Togedemaru, 348},
                {Species.Snom, 349},
                {Species.Frosmoth, 350},
                {Species.Clobbopus, 351},
                {Species.Grapploct, 352},
                {Species.Pincurchin, 353},
                {Species.Mantyke, 354},
                {Species.Mantine, 355},
                {Species.Wailmer, 356},
                {Species.Wailord, 357},
                {Species.Bergmite, 358},
                {Species.Avalugg, 359},
                {Species.Dhelmise, 360},
                {Species.Lapras, 361},
                {Species.Lunatone, 362},
                {Species.Solrock, 363},
                {Species.MimeJr, 364},
                {Species.MrMime, 365},
                {Species.MrRime, 366},
                {Species.Darumaka, 367},
                {Species.Darmanitan, 368},
                {Species.Stonjourner, 369},
                {Species.Eiscue, 370},
                {Species.Duraludon, 371},
                {Species.Rotom, 372},
                {Species.Ditto, 373},
                {Species.Dracozolt, 374},
                {Species.Arctozolt, 375},
                {Species.Dracovish, 376},
                {Species.Arctovish, 377},
                {Species.Charmander, 378},
                {Species.Charmeleon, 379},
                {Species.Charizard, 380},
                {Species.TypeNull, 381},
                {Species.Silvally, 382},
                {Species.Larvitar, 383},
                {Species.Pupitar, 384},
                {Species.Tyranitar, 385},
                {Species.Deino, 386},
                {Species.Zweilous, 387},
                {Species.Hydreigon, 388},
                {Species.Goomy, 389},
                {Species.Sliggoo, 390},
                {Species.Goodra, 391},
                {Species.Jangmoo, 392},
                {Species.Hakamoo, 393},
                {Species.Kommoo, 394},
                {Species.Dreepy, 395},
                {Species.Drakloak, 396},
                {Species.Dragapult, 397},
                {Species.Zacian, 398},
                {Species.Zamazenta, 399},
                {Species.Eternatus, 400},
       */
        };
    }
}
