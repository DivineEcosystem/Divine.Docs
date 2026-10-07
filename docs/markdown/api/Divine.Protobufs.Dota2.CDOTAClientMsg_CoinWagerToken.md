# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CoinWagerToken"></a> Class CDOTAClientMsg\_CoinWagerToken

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_CoinWagerToken : IMessage<CDOTAClientMsg_CoinWagerToken>, IEquatable<CDOTAClientMsg_CoinWagerToken>, IDeepCloneable<CDOTAClientMsg_CoinWagerToken>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_CoinWagerToken](Divine.Protobufs.Dota2.CDOTAClientMsg\_CoinWagerToken.md)

#### Implements

IMessage<CDOTAClientMsg\_CoinWagerToken\>, 
[IEquatable<CDOTAClientMsg\_CoinWagerToken\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_CoinWagerToken\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_CoinWagerToken\>\(CDOTAClientMsg\_CoinWagerToken, params CDOTAClientMsg\_CoinWagerToken\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CoinWagerToken__ctor"></a> CDOTAClientMsg\_CoinWagerToken\(\)

```csharp
public CDOTAClientMsg_CoinWagerToken()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CoinWagerToken__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_CoinWagerToken_"></a> CDOTAClientMsg\_CoinWagerToken\(CDOTAClientMsg\_CoinWagerToken\)

```csharp
public CDOTAClientMsg_CoinWagerToken(CDOTAClientMsg_CoinWagerToken other)
```

#### Parameters

`other` [CDOTAClientMsg\_CoinWagerToken](Divine.Protobufs.Dota2.CDOTAClientMsg\_CoinWagerToken.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CoinWagerToken_WagerTokenItemIdFieldNumber"></a> WagerTokenItemIdFieldNumber

```csharp
public const int WagerTokenItemIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CoinWagerToken_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CoinWagerToken_HasWagerTokenItemId"></a> HasWagerTokenItemId

```csharp
public bool HasWagerTokenItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CoinWagerToken_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_CoinWagerToken> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_CoinWagerToken](Divine.Protobufs.Dota2.CDOTAClientMsg\_CoinWagerToken.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CoinWagerToken_WagerTokenItemId"></a> WagerTokenItemId

```csharp
public ulong WagerTokenItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CoinWagerToken_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CoinWagerToken_ClearWagerTokenItemId"></a> ClearWagerTokenItemId\(\)

```csharp
public void ClearWagerTokenItemId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CoinWagerToken_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_CoinWagerToken Clone()
```

#### Returns

 [CDOTAClientMsg\_CoinWagerToken](Divine.Protobufs.Dota2.CDOTAClientMsg\_CoinWagerToken.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CoinWagerToken_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CoinWagerToken_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_CoinWagerToken_"></a> Equals\(CDOTAClientMsg\_CoinWagerToken\)

```csharp
public bool Equals(CDOTAClientMsg_CoinWagerToken other)
```

#### Parameters

`other` [CDOTAClientMsg\_CoinWagerToken](Divine.Protobufs.Dota2.CDOTAClientMsg\_CoinWagerToken.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CoinWagerToken_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CoinWagerToken_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_CoinWagerToken_"></a> MergeFrom\(CDOTAClientMsg\_CoinWagerToken\)

```csharp
public void MergeFrom(CDOTAClientMsg_CoinWagerToken other)
```

#### Parameters

`other` [CDOTAClientMsg\_CoinWagerToken](Divine.Protobufs.Dota2.CDOTAClientMsg\_CoinWagerToken.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CoinWagerToken_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CoinWagerToken_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CoinWagerToken_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

