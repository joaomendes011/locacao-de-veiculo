Cliente cliente1 = new Cliente(
    "JUAN",
    "AL000001"
);
 
Cliente cliente2 = new Cliente(
    "ANTONIA",
    "AL000002"
);
 
 
Veiculo veiculo1 = new Veiculo(
    "Toyota Corolla Cross",
    "BRA2E26"
);
 
Veiculo veiculo2 = new Veiculo(
    "BMW 320I",
    "KRT4A15"
);
 
 
Locacao locacao1 = new Locacao(
    cliente1,
    veiculo1,
    new DateOnly(2026, 10, 8),
    5,
    150m
);
 
 
Locacao locacao2 = new Locacao(
    cliente2,
    veiculo2,
    new DateOnly(2026, 10, 8),
    10,
    200m
);
 
 
Console.WriteLine("SISTEMA DE LOCAÇÃO DE VEÍCULOS");
Console.WriteLine();
 
locacao1.ExibirResumo();
 
Console.WriteLine();
 
locacao2.ExibirResumo();