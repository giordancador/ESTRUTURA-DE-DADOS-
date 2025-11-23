using System.Collections.Generic;
using System.Linq;

// Aplicativo simples para gerenciar rastreio -> código de barras
var dict = new Dictionary<string, string>();

void MostrarMenu()
{
	Console.WriteLine();
	Console.WriteLine("=== Sistema de Rastreio e Códigos de Barras ===");
	Console.WriteLine("1 - Inserir novo registro");
	Console.WriteLine("2 - Buscar por código de rastreio");
	Console.WriteLine("3 - Buscar por código de barras");
	Console.WriteLine("4 - Listar todos os registros");
	Console.WriteLine("5 - Remover um registro por rastreio");
	Console.WriteLine("0 - Sair");
	Console.Write("Escolha uma opção: ");
}

string LerNaoVazio(string prompt)
{
	while (true)
	{
		Console.Write(prompt);
		var s = Console.ReadLine();
		if (!string.IsNullOrWhiteSpace(s)) return s.Trim();
		Console.WriteLine("Entrada inválida. Por favor, informe um valor não vazio.");
	}
}

bool PerguntaSimNao(string pergunta)
{
	while (true)
	{
		Console.Write(pergunta + " (S/N): ");
		var r = Console.ReadLine();
		if (string.IsNullOrWhiteSpace(r)) continue;
		r = r.Trim().ToUpperInvariant();
		if (r == "S" || r == "SIM") return true;
		if (r == "N" || r == "NAO" || r == "NÃO") return false;
		Console.WriteLine("Resposta inválida. Digite S para sim ou N para não.");
	}
}

void InserirRegistro()
{
	var rastreio = LerNaoVazio("Informe o código de rastreio: ");
	var codigo = LerNaoVazio("Informe o código de barras da encomenda: ");

	if (dict.ContainsKey(rastreio))
	{
		Console.WriteLine($"Atenção: já existe um registro com o rastreio '{rastreio}'.");
		if (PerguntaSimNao("Deseja substituir o código de barras existente?"))
		{
			dict[rastreio] = codigo;
			Console.WriteLine("Registro atualizado com sucesso.");
		}
		else
		{
			Console.WriteLine("Operação cancelada. Nenhuma alteração efetuada.");
		}
		return;
	}

	// Verifica se o código de barras já está associado a outro rastreio
	var duplicado = dict.FirstOrDefault(kv => kv.Value == codigo);
	if (!duplicado.Equals(default(KeyValuePair<string, string>)))
	{
		Console.WriteLine($"Aviso: o código de barras '{codigo}' já está associado ao rastreio '{duplicado.Key}'.");
		if (!PerguntaSimNao("Deseja prosseguir e adicionar mesmo assim?"))
		{
			Console.WriteLine("Operação cancelada. Nenhum registro adicionado.");
			return;
		}
	}

	dict[rastreio] = codigo;
	Console.WriteLine("Registro adicionado com sucesso.");
}

void BuscarPorRastreio()
{
	var rastreio = LerNaoVazio("Informe o código de rastreio para busca: ");
	if (dict.TryGetValue(rastreio, out var codigo))
	{
		Console.WriteLine($"Encontrado: Rastreio = {rastreio}  |  Código de Barras = {codigo}");
	}
	else
	{
		Console.WriteLine($"Nenhum registro encontrado para o rastreio '{rastreio}'.");
	}
}

void BuscarPorCodigoDeBarras()
{
	var codigo = LerNaoVazio("Informe o código de barras para busca: ");
	var encontrados = dict.Where(kv => kv.Value == codigo).ToList();
	if (encontrados.Count == 0)
	{
		Console.WriteLine($"Nenhum registro encontrado para o código de barras '{codigo}'.");
		return;
	}

	Console.WriteLine($"Foram encontrados {encontrados.Count} registro(s) para o código de barras '{codigo}':");
	foreach (var kv in encontrados)
	{
		Console.WriteLine($" - Rastreio: {kv.Key}");
	}
}

void ListarTodos()
{
	if (dict.Count == 0)
	{
		Console.WriteLine("Nenhum registro cadastrado.");
		return;
	}

	Console.WriteLine($"Total de registros: {dict.Count}");
	foreach (var kv in dict)
	{
		Console.WriteLine($"Rastreio: {kv.Key}  |  Código de Barras: {kv.Value}");
	}
}

void RemoverRegistro()
{
	var rastreio = LerNaoVazio("Informe o código de rastreio a remover: ");
	if (dict.Remove(rastreio))
	{
		Console.WriteLine("Registro removido com sucesso.");
	}
	else
	{
		Console.WriteLine($"Nenhum registro encontrado para o rastreio '{rastreio}'.");
	}
}

// Loop principal
while (true)
{
	MostrarMenu();
	var opc = Console.ReadLine();
	if (string.IsNullOrWhiteSpace(opc)) { Console.WriteLine("Opção inválida."); continue; }
	switch (opc.Trim())
	{
		case "1": InserirRegistro(); break;
		case "2": BuscarPorRastreio(); break;
		case "3": BuscarPorCodigoDeBarras(); break;
		case "4": ListarTodos(); break;
		case "5": RemoverRegistro(); break;
		case "0": Console.WriteLine("Saindo. Até logo!"); return;
		default: Console.WriteLine("Opção inválida. Tente novamente."); break;
	}
}
