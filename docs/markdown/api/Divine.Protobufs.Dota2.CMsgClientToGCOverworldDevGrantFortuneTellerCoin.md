# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoin"></a> Class CMsgClientToGCOverworldDevGrantFortuneTellerCoin

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverworldDevGrantFortuneTellerCoin : IMessage<CMsgClientToGCOverworldDevGrantFortuneTellerCoin>, IEquatable<CMsgClientToGCOverworldDevGrantFortuneTellerCoin>, IDeepCloneable<CMsgClientToGCOverworldDevGrantFortuneTellerCoin>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverworldDevGrantFortuneTellerCoin](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevGrantFortuneTellerCoin.md)

#### Implements

IMessage<CMsgClientToGCOverworldDevGrantFortuneTellerCoin\>, 
[IEquatable<CMsgClientToGCOverworldDevGrantFortuneTellerCoin\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverworldDevGrantFortuneTellerCoin\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverworldDevGrantFortuneTellerCoin\>\(CMsgClientToGCOverworldDevGrantFortuneTellerCoin, params CMsgClientToGCOverworldDevGrantFortuneTellerCoin\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoin__ctor"></a> CMsgClientToGCOverworldDevGrantFortuneTellerCoin\(\)

```csharp
public CMsgClientToGCOverworldDevGrantFortuneTellerCoin()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoin__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoin_"></a> CMsgClientToGCOverworldDevGrantFortuneTellerCoin\(CMsgClientToGCOverworldDevGrantFortuneTellerCoin\)

```csharp
public CMsgClientToGCOverworldDevGrantFortuneTellerCoin(CMsgClientToGCOverworldDevGrantFortuneTellerCoin other)
```

#### Parameters

`other` [CMsgClientToGCOverworldDevGrantFortuneTellerCoin](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevGrantFortuneTellerCoin.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoin_OverworldIdFieldNumber"></a> OverworldIdFieldNumber

```csharp
public const int OverworldIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoin_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoin_HasOverworldId"></a> HasOverworldId

```csharp
public bool HasOverworldId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoin_OverworldId"></a> OverworldId

```csharp
public uint OverworldId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoin_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverworldDevGrantFortuneTellerCoin> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverworldDevGrantFortuneTellerCoin](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevGrantFortuneTellerCoin.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoin_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoin_ClearOverworldId"></a> ClearOverworldId\(\)

```csharp
public void ClearOverworldId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoin_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverworldDevGrantFortuneTellerCoin Clone()
```

#### Returns

 [CMsgClientToGCOverworldDevGrantFortuneTellerCoin](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevGrantFortuneTellerCoin.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoin_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoin_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoin_"></a> Equals\(CMsgClientToGCOverworldDevGrantFortuneTellerCoin\)

```csharp
public bool Equals(CMsgClientToGCOverworldDevGrantFortuneTellerCoin other)
```

#### Parameters

`other` [CMsgClientToGCOverworldDevGrantFortuneTellerCoin](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevGrantFortuneTellerCoin.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoin_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoin_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoin_"></a> MergeFrom\(CMsgClientToGCOverworldDevGrantFortuneTellerCoin\)

```csharp
public void MergeFrom(CMsgClientToGCOverworldDevGrantFortuneTellerCoin other)
```

#### Parameters

`other` [CMsgClientToGCOverworldDevGrantFortuneTellerCoin](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevGrantFortuneTellerCoin.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoin_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoin_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoin_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

