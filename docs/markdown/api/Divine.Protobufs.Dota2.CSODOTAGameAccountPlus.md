# <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus"></a> Class CSODOTAGameAccountPlus

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSODOTAGameAccountPlus : IMessage<CSODOTAGameAccountPlus>, IEquatable<CSODOTAGameAccountPlus>, IDeepCloneable<CSODOTAGameAccountPlus>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSODOTAGameAccountPlus](Divine.Protobufs.Dota2.CSODOTAGameAccountPlus.md)

#### Implements

IMessage<CSODOTAGameAccountPlus\>, 
[IEquatable<CSODOTAGameAccountPlus\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSODOTAGameAccountPlus\>, 
IBufferMessage, 
IMessage

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<CSODOTAGameAccountPlus\>\(CSODOTAGameAccountPlus, params CSODOTAGameAccountPlus\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus__ctor"></a> CSODOTAGameAccountPlus\(\)

```csharp
public CSODOTAGameAccountPlus()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus__ctor_Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_"></a> CSODOTAGameAccountPlus\(CSODOTAGameAccountPlus\)

```csharp
public CSODOTAGameAccountPlus(CSODOTAGameAccountPlus other)
```

#### Parameters

`other` [CSODOTAGameAccountPlus](Divine.Protobufs.Dota2.CSODOTAGameAccountPlus.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_NextPaymentDateFieldNumber"></a> NextPaymentDateFieldNumber

```csharp
public const int NextPaymentDateFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_OriginalStartDateFieldNumber"></a> OriginalStartDateFieldNumber

```csharp
public const int OriginalStartDateFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_PlusFlagsFieldNumber"></a> PlusFlagsFieldNumber

```csharp
public const int PlusFlagsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_PlusStatusFieldNumber"></a> PlusStatusFieldNumber

```csharp
public const int PlusStatusFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_PrepaidTimeBalanceFieldNumber"></a> PrepaidTimeBalanceFieldNumber

```csharp
public const int PrepaidTimeBalanceFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_PrepaidTimeStartFieldNumber"></a> PrepaidTimeStartFieldNumber

```csharp
public const int PrepaidTimeStartFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_SteamAgreementIdFieldNumber"></a> SteamAgreementIdFieldNumber

```csharp
public const int SteamAgreementIdFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_HasNextPaymentDate"></a> HasNextPaymentDate

```csharp
public bool HasNextPaymentDate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_HasOriginalStartDate"></a> HasOriginalStartDate

```csharp
public bool HasOriginalStartDate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_HasPlusFlags"></a> HasPlusFlags

```csharp
public bool HasPlusFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_HasPlusStatus"></a> HasPlusStatus

```csharp
public bool HasPlusStatus { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_HasPrepaidTimeBalance"></a> HasPrepaidTimeBalance

```csharp
public bool HasPrepaidTimeBalance { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_HasPrepaidTimeStart"></a> HasPrepaidTimeStart

```csharp
public bool HasPrepaidTimeStart { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_HasSteamAgreementId"></a> HasSteamAgreementId

```csharp
public bool HasSteamAgreementId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_NextPaymentDate"></a> NextPaymentDate

```csharp
public uint NextPaymentDate { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_OriginalStartDate"></a> OriginalStartDate

```csharp
public uint OriginalStartDate { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_Parser"></a> Parser

```csharp
public static MessageParser<CSODOTAGameAccountPlus> Parser { get; }
```

#### Property Value

 MessageParser<[CSODOTAGameAccountPlus](Divine.Protobufs.Dota2.CSODOTAGameAccountPlus.md)\>

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_PlusFlags"></a> PlusFlags

```csharp
public uint PlusFlags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_PlusStatus"></a> PlusStatus

```csharp
public uint PlusStatus { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_PrepaidTimeBalance"></a> PrepaidTimeBalance

```csharp
public uint PrepaidTimeBalance { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_PrepaidTimeStart"></a> PrepaidTimeStart

```csharp
public uint PrepaidTimeStart { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_SteamAgreementId"></a> SteamAgreementId

```csharp
public ulong SteamAgreementId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_ClearNextPaymentDate"></a> ClearNextPaymentDate\(\)

```csharp
public void ClearNextPaymentDate()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_ClearOriginalStartDate"></a> ClearOriginalStartDate\(\)

```csharp
public void ClearOriginalStartDate()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_ClearPlusFlags"></a> ClearPlusFlags\(\)

```csharp
public void ClearPlusFlags()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_ClearPlusStatus"></a> ClearPlusStatus\(\)

```csharp
public void ClearPlusStatus()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_ClearPrepaidTimeBalance"></a> ClearPrepaidTimeBalance\(\)

```csharp
public void ClearPrepaidTimeBalance()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_ClearPrepaidTimeStart"></a> ClearPrepaidTimeStart\(\)

```csharp
public void ClearPrepaidTimeStart()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_ClearSteamAgreementId"></a> ClearSteamAgreementId\(\)

```csharp
public void ClearSteamAgreementId()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_Clone"></a> Clone\(\)

```csharp
public CSODOTAGameAccountPlus Clone()
```

#### Returns

 [CSODOTAGameAccountPlus](Divine.Protobufs.Dota2.CSODOTAGameAccountPlus.md)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_Equals_Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_"></a> Equals\(CSODOTAGameAccountPlus\)

```csharp
public bool Equals(CSODOTAGameAccountPlus other)
```

#### Parameters

`other` [CSODOTAGameAccountPlus](Divine.Protobufs.Dota2.CSODOTAGameAccountPlus.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_MergeFrom_Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_"></a> MergeFrom\(CSODOTAGameAccountPlus\)

```csharp
public void MergeFrom(CSODOTAGameAccountPlus other)
```

#### Parameters

`other` [CSODOTAGameAccountPlus](Divine.Protobufs.Dota2.CSODOTAGameAccountPlus.md)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountPlus_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

