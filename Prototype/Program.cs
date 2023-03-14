using Prototype.Nuvens;

GerenciadorNuvens gerenciador_de_nuvens = new GerenciadorNuvens();

gerenciador_de_nuvens["padrão"] = new NuvemConcreta("branco", "azul");
gerenciador_de_nuvens["personalizada_1"] = new NuvemConcreta("branco", "laranja");
gerenciador_de_nuvens["personalizada_2"] = new NuvemConcreta("cinza", "verde");

NuvemConcreta um = gerenciador_de_nuvens["padrão"].Clone() as NuvemConcreta;
NuvemConcreta dois = gerenciador_de_nuvens["padrão"].Clone() as NuvemConcreta;
NuvemConcreta tres = gerenciador_de_nuvens["personalizada_1"].Clone() as NuvemConcreta;
NuvemConcreta quatro = gerenciador_de_nuvens["personalizada_2"].Clone() as NuvemConcreta;

Console.ReadKey();