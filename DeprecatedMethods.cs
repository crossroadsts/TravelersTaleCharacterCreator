#region Vocational Skills (deprecated)

// int voc1 = 0;
// int voc2 = 0;

// bool vocCheckFailed = true;
// while(vocCheckFailed) {
//     Console.WriteLine("Select 2 Vocational Skills (press enter after each):");
//     foreach (var voc in Enum.GetValues(typeof(VocationalSkillsEnum)))
//     {
//         Console.WriteLine((int)voc + ": " + voc);
//     }

//     voc1 = Convert.ToInt32(Console.ReadLine());
//     voc2 = Convert.ToInt32(Console.ReadLine());

//     HashSet<int> vocs = new(){voc1, voc2};
//     vocCheckFailed = vocs.Count != 2;

//     if (vocCheckFailed) {
//         Console.WriteLine("\nYou can only pick each Vocational Skill one time.");
//     }
// }

// List<VocationalSkillsEnum> selectedVocs = new()
// {
//     (VocationalSkillsEnum)voc1,
//     (VocationalSkillsEnum)voc2,
// };

// foreach (var selectedVoc in selectedVocs)
// {
//     switch(selectedVoc) {
//         case VocationalSkillsEnum.Farming:
//             character.Farming += 1;
//             break;
//         case VocationalSkillsEnum.Science:
//             character.Science += 1;
//             break;
//         case VocationalSkillsEnum.Cooking:
//             character.Cooking += 1;
//             break;
//         case VocationalSkillsEnum.Medicine:
//             character.Medicine += 1;
//             break;
//         case VocationalSkillsEnum.Mechanics:
//             character.Mechanics += 1;
//             break;
//         case VocationalSkillsEnum.Technology:
//             character.Technology += 1;
//             break;
//         case VocationalSkillsEnum.Carpentry:
//             character.Carpentry += 1;
//             break;
//         case VocationalSkillsEnum.Smithing:
//             character.Smithing += 1;
//             break;
//         case VocationalSkillsEnum.Mounting:
//             character.Mounting += 1;
//             break;
//         case VocationalSkillsEnum.Fishing:
//             character.Fishing += 1;
//             break;
//         case VocationalSkillsEnum.Alchemy:
//             character.Alchemy += 1;
//             break;
//         case VocationalSkillsEnum.Weaving:
//             character.Weaving += 1;
//             break;
//         case VocationalSkillsEnum.Leatherworking:
//             character.Leatherworking += 1;
//             break;
//         case VocationalSkillsEnum.Music:
//             character.Music += 1;
//             break;
//         case VocationalSkillsEnum.Art:
//             character.Art += 1;
//             break;
//         case VocationalSkillsEnum.Botany:
//             character.Botany += 1;
//             break;
//         case VocationalSkillsEnum.Hunting:
//             character.Hunting += 1;
//             break;
//         case VocationalSkillsEnum.Skinning:
//             character.Skinning += 1;
//             break;
//         case VocationalSkillsEnum.Foraging:
//             character.Foraging += 1;
//             break;
//         case VocationalSkillsEnum.Taming:
//             character.Taming += 1;
//             break;
//         case VocationalSkillsEnum.Piloting:
//             character.Piloting += 1;
//             break;
//         case VocationalSkillsEnum.Sailing:
//             character.Sailing += 1;
//             break;
//         default:
//             break;
//     }
// }
#endregion



#region Discipline (deprecated)
// Console.WriteLine("Select a Discipline:");
// foreach (var discipline in Enum.GetValues(typeof(DisciplinesEnum)))
// {
//     Console.WriteLine((int)discipline + ": " + discipline);
// }
// int disciplineInput = Convert.ToInt32(Console.ReadLine());
// var disciplineSelection = (DisciplinesEnum)disciplineInput;

// switch(disciplineSelection) {
//     case DisciplinesEnum.Necroblade:
//         character.Discipline = new Necroblade();
//         break;
//     case DisciplinesEnum.Pugalist:
//         character.Discipline = new Pugalist();
//         break;
//     case DisciplinesEnum.Tyrant:
//         character.Discipline = new Tyrant();
//         break;
//     case DisciplinesEnum.Warrior:
//         character.Discipline = new Warrior();
//         break;
//     case DisciplinesEnum.Ranger:
//         character.Discipline = new Ranger();
//         break;
//     case DisciplinesEnum.Vigilante:
//         character.Discipline = new Vigilante();
//         break;
//     default:
//         break;
// }

// int disciplineProf1 = 0;
// int disciplineProf2 = 0;
// int disciplineProf3 = 0;

// bool disciplineProfCheckFailed = true;
// while(disciplineProfCheckFailed) {
//     Console.WriteLine("Select 3 Proficiencies (press enter after each):");
//     int profNum = 1;
//     foreach (var prof in character.Discipline.PossibleProficiencies)
//     {
//         Console.WriteLine(profNum + ": " + prof);
//         profNum++;
//     }

//     disciplineProf1 = Convert.ToInt32(Console.ReadLine());
//     disciplineProf2 = Convert.ToInt32(Console.ReadLine());
//     disciplineProf3 = Convert.ToInt32(Console.ReadLine());

//     HashSet<int> profs = new(){disciplineProf1, disciplineProf2, disciplineProf3};
//     disciplineProfCheckFailed = profs.Count != 3;

//     if (disciplineProfCheckFailed) {
//         Console.WriteLine("\nYou can only pick each Proficiency one time.");
//     }
// }

// List<ProficienciesEnum> selectedDisciplineProficiencies = new()
// {
//     character.Discipline.PossibleProficiencies[disciplineProf1-1],
//     character.Discipline.PossibleProficiencies[disciplineProf2-1],
//     character.Discipline.PossibleProficiencies[disciplineProf3-1],
// };

// foreach (var selectedProf in selectedDisciplineProficiencies)
// {
//     switch(selectedProf) {
//         case ProficienciesEnum.Athletics:
//             character.Athletics += 1;
//             break;
//         case ProficienciesEnum.Strength:
//             character.Strength += 1;
//             break;
//         case ProficienciesEnum.Intimidation:
//             character.Intimidation += 1;
//             break;
//         case ProficienciesEnum.Skulduggery:
//             character.Skulduggery += 1;
//             break;
//         case ProficienciesEnum.Stealth:
//             character.Stealth += 1;
//             break;
//         case ProficienciesEnum.Acrobatics:
//             character.Acrobatics += 1;
//             break;
//         case ProficienciesEnum.Constitution:
//             character.Constitution += 1;
//             break;
//         case ProficienciesEnum.Navigation:
//             character.Navigation += 1;
//             break;
//         case ProficienciesEnum.Survival:
//             character.Survival += 1;
//             break;
//         case ProficienciesEnum.Lore:
//             character.Lore += 1;
//             break;
//         case ProficienciesEnum.Perception:
//             character.Perception += 1;
//             break;
//         case ProficienciesEnum.Anima:
//             character.Anima += 1;
//             break;
//         case ProficienciesEnum.Deduction:
//             character.Deduction += 1;
//             break;
//         case ProficienciesEnum.Streetwise:
//             character.Streetwise += 1;
//             break;
//         case ProficienciesEnum.Barter:
//             character.Barter += 1;
//             break;
//         case ProficienciesEnum.Charm:
//             character.Charm += 1;
//             break;
//         case ProficienciesEnum.Rally:
//             character.Rally += 1;
//             break;
//         case ProficienciesEnum.Cool:
//             character.Cool += 1;
//             break;
//         case ProficienciesEnum.Diplomacy:
//             character.Cool += 1;
//             break;
//         default:
//             break;
//     }
// }

#endregion

#region Roll for XP (deprecated)

// Console.WriteLine("Rolling for XP...");

// int totalXP = RollForXP();

// while (totalXP >= 50) {
//     Console.WriteLine("Total XP Remaining: " + totalXP);
//     Console.WriteLine("Select a Stat to Level Up (-50 XP):");
//     foreach (var coreStat in Enum.GetValues(typeof(CoreStatsEnum)))
//     {
//         Console.Write((int)coreStat + ": " + coreStat + " - Current Level: ");

//         switch(coreStat) {
//             case CoreStatsEnum.Power:
//                 Console.Write(character.Power + "\n");
//                 break;
//             case CoreStatsEnum.Speed:
//                 Console.Write(character.Speed + "\n");
//                 break;
//             case CoreStatsEnum.Vigor:
//                 Console.Write(character.Vigor + "\n");
//                 break;
//             case CoreStatsEnum.Wit:
//                 Console.Write(character.Wit + "\n");
//                 break;
//             case CoreStatsEnum.Presence:
//                 Console.Write(character.Presence + "\n");
//                 break;
//             default:
//                 break;
//         }
//     }

//     int statInput = Convert.ToInt32(Console.ReadLine());
//     var statSelection = (CoreStatsEnum)statInput;

//     switch(statSelection) {
//         case CoreStatsEnum.Power:
//             if (character.Power < 10) {
//                 character.Power += 1;
//                 totalXP -= 50;
//             }
//             else {
//                 Console.WriteLine("Power is already at Level 10. Pick a different stat.");
//             }
//             break;
//         case CoreStatsEnum.Speed:
//             if (character.Speed < 10) {
//                 character.Speed += 1;
//                 totalXP -= 50;
//             }
//             else {
//                 Console.WriteLine("Speed is already at Level 10. Pick a different stat.");
//             }
//             break;
//         case CoreStatsEnum.Vigor:
//             if (character.Vigor < 10) {
//                 character.Vigor += 1;
//                 totalXP -= 50;
//             }
//             else {
//                 Console.WriteLine("Vigor is already at Level 10. Pick a different stat.");
//             }
//             break;
//         case CoreStatsEnum.Wit:
//             if (character.Wit < 10) {
//                 character.Wit += 1;
//                 totalXP -= 50;
//             }
//             else {
//                 Console.WriteLine("Wit is already at Level 10. Pick a different stat.");
//             }
//             break;
//         case CoreStatsEnum.Presence:
//             if (character.Presence < 10) {
//                 character.Presence += 1;
//                 totalXP -= 50;
//             }
//             else {
//                 Console.WriteLine("Presence is already at Level 10. Pick a different stat.");
//             }
//             break;
//         default:
//             break;
//     }
// }

// character.SkillXP = totalXP;
// Console.WriteLine("Remaining XP for your Skill XP Pool: " + character.SkillXP + "\n");
#endregion


#region Wren (not implemented)
// Console.WriteLine("Select a Wren:");
// foreach (var wren in Enum.GetValues(typeof(WrensEnum)))
// {
//     Console.WriteLine((int)wren + ": " + wren);
// }
// int wrenInput = Convert.ToInt32(Console.ReadLine());
// var wrenSelection = (WrensEnum)wrenInput;

// switch(wrenSelection) {
//     case WrensEnum.Evoker:
//         character.Wren = new Evoker();
//         break;
//     case WrensEnum.Conjuror:
//         character.Wren = new Conjuror();
//         break;
//     case WrensEnum.Enchanter:
//         character.Wren = new Enchanter();
//         break;
//     case WrensEnum.Transmutation:
//         character.Wren = new Transmutation();
//         break;
//     case WrensEnum.Restoration:
//         character.Wren = new Restoration();
//         break;
//     case WrensEnum.Divination:
//         character.Wren = new Divination();
//         break;
//     default:
//         break;
// }
// todo: finish wren
#endregion


#region Equipment
// int eq1 = 0;
// int eq2 = 0;
// int eq3 = 0;

// bool eqCheckFailed = true;
// while(eqCheckFailed) {
//     Console.WriteLine("Select 3 pieces of Equipment (press enter after each):");
//     foreach (EquipmentEnum eq in Enum.GetValues(typeof(EquipmentEnum)))
//     {
//         Console.WriteLine((int)eq + ": " + GetDisplayName(eq));
//     }

//     eq1 = Convert.ToInt32(Console.ReadLine());
//     eq2 = Convert.ToInt32(Console.ReadLine());
//     eq3 = Convert.ToInt32(Console.ReadLine());

//     HashSet<int> eqs = new(){eq1, eq2, eq3};
//     eqCheckFailed = eqs.Count != 3;

//     if (eqCheckFailed) {
//         Console.WriteLine("\nYou can only pick each piece of Equipment one time.");
//     }
// }

// character.Equipment = new()
// {
//     (EquipmentEnum)eq1,
//     (EquipmentEnum)eq2,
//     (EquipmentEnum)eq3,
// };

// foreach (var selectedEq in character.Equipment)
// {
//     switch(selectedEq) {
//         case EquipmentEnum.Other:
//             Console.WriteLine("What \"Other...\" Equipment do you want? (1 item):");
//             character.otherEquipment = Console.ReadLine();
//             break;
//         default:
//             break;
//     }
// }

#endregion



#region Persona
// Console.WriteLine("Select a Persona:");
// foreach (var persona in Enum.GetValues(typeof(PersonasEnum)))
// {
//     Console.WriteLine((int)persona + ": " + persona);
// }
// int personaInput = Convert.ToInt32(Console.ReadLine());
// var personaSelection = (PersonasEnum)personaInput;

// switch(personaSelection) {
//     case PersonasEnum.Bullwark:
//         character.Persona = PersonasEnum.Bullwark;
//         break;
//     case PersonasEnum.Sage:
//         character.Persona = PersonasEnum.Sage;
//         break;
//     case PersonasEnum.Jack:
//         character.Persona = PersonasEnum.Jack;
//         JackBackgroundSKills(character);
//         break;
//     case PersonasEnum.Rover:
//         character.Persona = PersonasEnum.Rover;
//         character.Movement += 10;
//         break;
//     case PersonasEnum.Prodigy:
//         character.Persona = PersonasEnum.Prodigy;
//         // todo, implement later
//         break;
//     default:
//         break;
// }
#endregion



#region Race Proficiencies
// int prof1 = 0;
// int prof2 = 0;
// int prof3 = 0;
// int prof4 = 0;
// int prof5 = 0;

// bool profCheckFailed = true;
// while(profCheckFailed) {
//     Console.WriteLine("Select 5 Proficiencies (press enter after each):");
//     int profNum = 1;
//     foreach (var prof in character.PossibleProficiencies)
//     {
//         Console.WriteLine(profNum + ": " + prof);
//         profNum++;
//     }

//     prof1 = Convert.ToInt32(Console.ReadLine());
//     prof2 = Convert.ToInt32(Console.ReadLine());
//     prof3 = Convert.ToInt32(Console.ReadLine());
//     prof4 = Convert.ToInt32(Console.ReadLine());
//     prof5 = Convert.ToInt32(Console.ReadLine());

//     HashSet<int> profs = new(){prof1, prof2, prof3, prof4, prof5};
//     profCheckFailed = profs.Count != 5;

//     if (profCheckFailed) {
//         Console.WriteLine("\nYou can only pick each Proficiency one time.");
//     }
// }

// List<ProficienciesEnum> selectedProficiencies = new()
// {
//     character.PossibleProficiencies[prof1-1],
//     character.PossibleProficiencies[prof2-1],
//     character.PossibleProficiencies[prof3-1],
//     character.PossibleProficiencies[prof4-1],
//     character.PossibleProficiencies[prof5-1]
// };

// foreach (var selectedProf in selectedProficiencies)
// {
//     switch(selectedProf) {
//         case ProficienciesEnum.Athletics:
//             character.Athletics += 1;
//             break;
//         case ProficienciesEnum.Strength:
//             character.Strength += 1;
//             break;
//         case ProficienciesEnum.Intimidation:
//             character.Intimidation += 1;
//             break;
//         case ProficienciesEnum.Skulduggery:
//             character.Skulduggery += 1;
//             break;
//         case ProficienciesEnum.Stealth:
//             character.Stealth += 1;
//             break;
//         case ProficienciesEnum.Acrobatics:
//             character.Acrobatics += 1;
//             break;
//         case ProficienciesEnum.Constitution:
//             character.Constitution += 1;
//             break;
//         case ProficienciesEnum.Navigation:
//             character.Navigation += 1;
//             break;
//         case ProficienciesEnum.Survival:
//             character.Survival += 1;
//             break;
//         case ProficienciesEnum.Lore:
//             character.Lore += 1;
//             break;
//         case ProficienciesEnum.Perception:
//             character.Perception += 1;
//             break;
//         case ProficienciesEnum.Anima:
//             character.Anima += 1;
//             break;
//         case ProficienciesEnum.Deduction:
//             character.Deduction += 1;
//             break;
//         case ProficienciesEnum.Streetwise:
//             character.Streetwise += 1;
//             break;
//         case ProficienciesEnum.Barter:
//             character.Barter += 1;
//             break;
//         case ProficienciesEnum.Charm:
//             character.Charm += 1;
//             break;
//         case ProficienciesEnum.Rally:
//             character.Rally += 1;
//             break;
//         case ProficienciesEnum.Cool:
//             character.Cool += 1;
//             break;
//         case ProficienciesEnum.Diplomacy:
//             character.Cool += 1;
//             break;
//         default:
//             break;
//     }
// }
#endregion


// static void UpdateCharacterVocationalSkills(BaseCharacter character, List<VocationalSkillsEnum> selectedVocs) {
//     foreach (var selectedVoc in selectedVocs)
//     {
//         switch(selectedVoc) {
//             case VocationalSkillsEnum.Farming:
//                 character.Farming += 1;
//                 break;
//             case VocationalSkillsEnum.Science:
//                 character.Science += 1;
//                 break;
//             case VocationalSkillsEnum.Cooking:
//                 character.Cooking += 1;
//                 break;
//             case VocationalSkillsEnum.Medicine:
//                 character.Medicine += 1;
//                 break;
//             case VocationalSkillsEnum.Mechanics:
//                 character.Mechanics += 1;
//                 break;
//             case VocationalSkillsEnum.Technology:
//                 character.Technology += 1;
//                 break;
//             case VocationalSkillsEnum.Carpentry:
//                 character.Carpentry += 1;
//                 break;
//             case VocationalSkillsEnum.Smithing:
//                 character.Smithing += 1;
//                 break;
//             case VocationalSkillsEnum.Mounting:
//                 character.Mounting += 1;
//                 break;
//             case VocationalSkillsEnum.Fishing:
//                 character.Fishing += 1;
//                 break;
//             case VocationalSkillsEnum.Alchemy:
//                 character.Alchemy += 1;
//                 break;
//             case VocationalSkillsEnum.Weaving:
//                 character.Weaving += 1;
//                 break;
//             case VocationalSkillsEnum.Leatherworking:
//                 character.Leatherworking += 1;
//                 break;
//             case VocationalSkillsEnum.Music:
//                 character.Music += 1;
//                 break;
//             case VocationalSkillsEnum.Art:
//                 character.Art += 1;
//                 break;
//             case VocationalSkillsEnum.Botany:
//                 character.Botany += 1;
//                 break;
//             case VocationalSkillsEnum.Hunting:
//                 character.Hunting += 1;
//                 break;
//             case VocationalSkillsEnum.Skinning:
//                 character.Skinning += 1;
//                 break;
//             case VocationalSkillsEnum.Foraging:
//                 character.Foraging += 1;
//                 break;
//             case VocationalSkillsEnum.Taming:
//                 character.Taming += 1;
//                 break;
//             case VocationalSkillsEnum.Piloting:
//                 character.Piloting += 1;
//                 break;
//             case VocationalSkillsEnum.Sailing:
//                 character.Sailing += 1;
//                 break;
//             default:
//                 break;
//         }
//     }
// }


// static void JackBackgroundSKills(BaseCharacter character)
// {
//     Console.WriteLine("Choose your character's background skills (need half the XP to level them up):");
//     int backgroundSkill1 = 0;
//     int backgroundSkill2 = 0;
//     int backgroundSkill3 = 0;

//     bool backgroundSkillCheckFailed = true;

//     while(backgroundSkillCheckFailed) {
//         Console.WriteLine("Select 3 more Skills (press enter after each):\n");
//         Console.WriteLine("---------------- Proficiencies ----------------");
//         foreach (ProficienciesEnum prof in Enum.GetValues(typeof(ProficienciesEnum)))
//         {
//             if (!character.BackgroundProfSkills.Contains(prof))
//             {
//                 Console.WriteLine((int)prof + ": " + prof);
//             }
//         }
//         Console.WriteLine("---------------- Vocational Skills ----------------");
//         foreach (VocationalSkillsEnum voc in Enum.GetValues(typeof(VocationalSkillsEnum)))
//         {
//             if (!character.BackgroundVocSkills.Contains(voc))
//             {
//                 Console.WriteLine((int)voc + ": " + voc);
//             }
//         }

//         backgroundSkill1 = Convert.ToInt32(Console.ReadLine());
//         backgroundSkill2 = Convert.ToInt32(Console.ReadLine());
//         backgroundSkill3 = Convert.ToInt32(Console.ReadLine());

//         HashSet<int> backs = new(){backgroundSkill1, backgroundSkill2, backgroundSkill3};
//         backgroundSkillCheckFailed = backs.Count != 3;

//         if (backgroundSkillCheckFailed) {
//             Console.WriteLine("\nYou can only pick each skill one time.");
//         }
//     }

//     if(backgroundSkill1 > Enum.GetValues(typeof(ProficienciesEnum)).Cast<int>().Max())
//     {
//             character.BackgroundVocSkills.Add((VocationalSkillsEnum)backgroundSkill1);
//     }
//     else
//     {
//         character.BackgroundProfSkills.Add((ProficienciesEnum)backgroundSkill1);
//     }

//     if(backgroundSkill2 > Enum.GetValues(typeof(ProficienciesEnum)).Cast<int>().Max())
//     {
//             character.BackgroundVocSkills.Add((VocationalSkillsEnum)backgroundSkill2);
//     }
//     else
//     {
//         character.BackgroundProfSkills.Add((ProficienciesEnum)backgroundSkill2);
//     }

//     if(backgroundSkill3 > Enum.GetValues(typeof(ProficienciesEnum)).Cast<int>().Max())
//     {
//             character.BackgroundVocSkills.Add((VocationalSkillsEnum)backgroundSkill3);
//     }
//     else
//     {
//         character.BackgroundProfSkills.Add((ProficienciesEnum)backgroundSkill3);
//     }
// }



//     static int RollForXP() 
// {
//     Random rnd = new Random();
//     int sum = 0;

//     for(var i = 0; i < 18; i++)
//     {
//         sum += rnd.Next(1, 7);
//     }

//     return sum *= 20;
// }