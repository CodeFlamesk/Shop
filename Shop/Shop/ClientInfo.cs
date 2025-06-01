namespace Shop;

public class ClientInfo
{
    public string Name { get;  }
    public Wallet MyWallet { get;  }

    public ClientInfo(string name, decimal money)
    {
        Name = name;
        MyWallet = new Wallet(money); 
    }
}

