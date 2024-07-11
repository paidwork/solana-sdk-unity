<p align="center">
  <img src="https://zrcdn.net/static/img/logos/paidwork/paidwork-logo-github.png" alt="Paidwork" />
</p>

<h3 align="center">
  Create, Send, Receive, Swap, Burn and Tax on Solana Blockchain
</h3>
<p align="center">
  🚀 Over 20K Worken holders!
</p>

<p align="center">
  <a href="https://github.com/paidwork/solana-sdk-unity">
    <img alt="GitHub Repository Stars Count" src="https://img.shields.io/github/stars/paidwork/solana-sdk-unity?style=social" />
  </a>
    <a href="https://x.com/paidworkco">
        <img alt="Follow Us on X" src="https://img.shields.io/twitter/follow/paidworkco?style=social" />
    </a>
</p>
<p align="center">
    <a href="http://commitizen.github.io/cz-cli/">
        <img alt="Commitizen friendly" src="https://img.shields.io/badge/commitizen-friendly-brightgreen.svg" />
    </a>
    <a href="https://github.com/paidwork/solana-sdk-php">
        <img alt="License" src="https://img.shields.io/github/license/paidwork/solana-sdk-php" />
    </a>
    <a href="https://github.com/paidwork/solana-sdk-php/pulls">
        <img alt="PRs Welcome" src="https://img.shields.io/badge/PRs-welcome-brightgreen.svg" />
    </a>
</p>

<a href="https://www.paidwork.com/worken?utm_source=github.com&utm_medium=referral&utm_campaign=readme" target="_blank">Read more</a> about Worken Token.

#References
[Newtonsoft.Json][Newtonsoft.Json]
[Solnet.Rpc][Solnet.Rpc]

#Release
https://github.com/paidworkco/solana-worken-sdk-unity/releases/tag/Release

## WalletManager

### CreateWallet
```csharp
WalletManager.CreateWallet();
```

#### Description
Create wallet and returns object [```WalletData```][1]
```csharp
 public class WalletData
 {
     public Account Account { get; set; }
     public Mnemonic Mnemonic { get; set; }
 }
```

### CreateWallet
```csharp
WalletManager.CreateWallet(WordCountType wordCount);
```

#### Description
Create wallet with [```wordCount```][wordCount1] needed as parameters  and returns object [```WalletData```][1]
```csharp
 public class WalletData
 {
     public Account Account { get; set; }
     public Mnemonic Mnemonic { get; set; }
 }
```

### CreateWallet
```csharp
WalletManager.CreateWallet(WordListType wordList);
```

#### Description
Create wallet with [```wordList```][wordList1] needed as parameters  and returns object [```WalletData```][1]
```csharp
 public class WalletData
 {
     public Account Account { get; set; }
     public Mnemonic Mnemonic { get; set; }
 }
```


### CreateWallet
```csharp
WalletManager.CreateWallet(WordListType wordList, WordCountType wordCount);
```

#### Description
Create wallet with [```wordList```][wordList1] and  [```wordCount```][wordCount1]  needed  as parameters and returns object [```WalletData```][1]
```csharp
 public class WalletData
 {
     public Account Account { get; set; }
     public Mnemonic Mnemonic { get; set; }
 }
```
##TransactionsManager

### CreateTransaction
```csharp
TransactionsManager.CreateTransaction(CreateTransactionRequest request);
```

#### Description
Send transaction based on object [```CreateTransactionRequest```][CreateTransactionRequest1]  passed as parameter and returns Transaction Hash as string
```csharp
String
```

### SimulateTransaction
```csharp
TransactionsManager.SimulateTransaction(CreateTransactionRequest request);
```

#### Description
Simulate transaction based on object [```CreateTransactionRequest```][CreateTransactionRequest1]  passed as parameter and returns Transaction Hash as string
Returns object [```SimulationLogs```][SimulationLogs1]


### CreateTransactionWithBurn
```csharp
TransactionsManager.CreateTransactionWithBurn(CreateTransactionBurnRequest request);
```

#### Description
Send transaction with additional burn instruction based on object [CreateTransactionBurnRequest] [CreateTransactionBurnRequest] but with additional burn instruction  passed as parameter and returns Transaction Hash as string
```csharp
String
```

### SimulateTransactionWithBurn
```csharp
TransactionsManager.SimulateTransactionWithBurn(CreateTransactionBurnRequest request);
```

#### Description
Simulate transaction with additional burn instruction based on object [```CreateTransactionBurnRequest```] [CreateTransactionBurnRequest]  passed as parameter and returns Transaction Hash as string
Returns object [```SimulationLogs```][SimulationLogs1]

### Burn
```csharp
TransactionsManager.Burn(CreateBurnRequest request);
```

#### Description
Send burn instruction based on object [```CreateBurnRequest```][CreateBurnRequest] but with additional burn instruction  passed as parameter and returns Transaction Hash as string
```csharp
String
```

### SimulateBurn
```csharp
TransactionsManager.SimulateTransactionWithBurn(CreateTransactionBurnRequest request);
```

#### Description
Simulate burn instruction based on object [```CreateBurnRequest```][CreateBurnRequest]  passed as parameter and returns Transaction Hash as string
Returns object [```SimulationLogs```][SimulationLogs1]



[1]: https://github.com/paidworkco/solana-worken-sdk-unity/blob/main/worken-sdk-unity/Wallet/model/walletObject/WalletData.cs "WalletData"
[wordCount1]: https://github.com/paidworkco/solana-worken-sdk-unity/blob/main/worken-sdk-unity/Wallet/model/WodCountType.cs "WordCount"
[wordList1]: https://github.com/paidworkco/solana-worken-sdk-unity/blob/main/worken-sdk-unity/Wallet/model/WordListType.cs "WordList"
[CreateTransactionRequest1]: https://github.com/paidworkco/solana-api/blob/master/worken-api/Models/CreateTransactionRequest.cs "CreateTransactionRequest"
[SimulationLogs1]: https://github.com/bmresearch/Solnet/blob/5fbb059997ba1a2cc61f31f2936b16d7325b5b72/src/Solnet.Rpc/Models/Logs.cs#L42 "SImulationLogs"
[Newtonsoft.Json]: https://www.nuget.org/packages/Newtonsoft.Json/13.0.3?_src=template "Newtonsoft.Json"
[Solnet.Rpc]: https://www.nuget.org/packages/Solnet.Rpc/6.1.0?_src=template "Solnet.Rpc"
[CreateTransactionBurnRequest]: https://github.com/paidworkco/solana-api/blob/master/worken-api/Models/CreateTransactionBurnRequest.cs "CreateTransactionBurnRequest"
[CreateBurnRequest]: https://github.com/paidworkco/solana-api/blob/master/worken-api/Models/CreateBurnRequest.cs "CreateBurnRequest"
