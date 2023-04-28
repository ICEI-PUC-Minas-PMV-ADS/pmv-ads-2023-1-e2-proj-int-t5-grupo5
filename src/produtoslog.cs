using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

public class Product
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("nome")]
    public string Nome { get; set; }

    [JsonPropertyName("preco")]
    public decimal Preco { get; set; }

    [JsonPropertyName("Stock")]
    public int Stock { get; set; }

    [JsonPropertyName("categoria")]
    public string Categoria { get; set; }
}

public class ProductService
{
    private readonly string _localStorageKey = "produtos";

    public void AddProduct(Product product)
    {
        // Recupera a lista atual de produtos do Local Storage
        var products = GetProducts();

        //Adiciona o novo produto à lista
        product.Add(product);

        //Armazena a lista atualizada no Local Storage
        var json = JsonSerializer.Serialize(products);
        localStorage.SetItem(_localStorageKey, json);

    }

    private List<Product> GetProducts()
    {
        // Recupera a lista atual de produtos do Local Storage
        var json = localStorage.GetItem<string>(_localStorageKey);
        if (json == null)
        {
            return new List<Product>();
        }
        return JsonSerializer.Deserialize<List<Product>>(json);

        public void SaveProduct
    }
}
