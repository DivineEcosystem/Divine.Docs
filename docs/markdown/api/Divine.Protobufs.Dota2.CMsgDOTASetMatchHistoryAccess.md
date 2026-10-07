# <a id="Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccess"></a> Class CMsgDOTASetMatchHistoryAccess

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTASetMatchHistoryAccess : IMessage<CMsgDOTASetMatchHistoryAccess>, IEquatable<CMsgDOTASetMatchHistoryAccess>, IDeepCloneable<CMsgDOTASetMatchHistoryAccess>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTASetMatchHistoryAccess](Divine.Protobufs.Dota2.CMsgDOTASetMatchHistoryAccess.md)

#### Implements

IMessage<CMsgDOTASetMatchHistoryAccess\>, 
[IEquatable<CMsgDOTASetMatchHistoryAccess\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTASetMatchHistoryAccess\>, 
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
[EnumerableExtensions.In<CMsgDOTASetMatchHistoryAccess\>\(CMsgDOTASetMatchHistoryAccess, params CMsgDOTASetMatchHistoryAccess\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccess__ctor"></a> CMsgDOTASetMatchHistoryAccess\(\)

```csharp
public CMsgDOTASetMatchHistoryAccess()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccess__ctor_Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccess_"></a> CMsgDOTASetMatchHistoryAccess\(CMsgDOTASetMatchHistoryAccess\)

```csharp
public CMsgDOTASetMatchHistoryAccess(CMsgDOTASetMatchHistoryAccess other)
```

#### Parameters

`other` [CMsgDOTASetMatchHistoryAccess](Divine.Protobufs.Dota2.CMsgDOTASetMatchHistoryAccess.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccess_Allow3RdPartyMatchHistoryFieldNumber"></a> Allow3RdPartyMatchHistoryFieldNumber

```csharp
public const int Allow3RdPartyMatchHistoryFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccess_Allow3RdPartyMatchHistory"></a> Allow3RdPartyMatchHistory

```csharp
public bool Allow3RdPartyMatchHistory { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccess_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccess_HasAllow3RdPartyMatchHistory"></a> HasAllow3RdPartyMatchHistory

```csharp
public bool HasAllow3RdPartyMatchHistory { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccess_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTASetMatchHistoryAccess> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTASetMatchHistoryAccess](Divine.Protobufs.Dota2.CMsgDOTASetMatchHistoryAccess.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccess_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccess_ClearAllow3RdPartyMatchHistory"></a> ClearAllow3RdPartyMatchHistory\(\)

```csharp
public void ClearAllow3RdPartyMatchHistory()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccess_Clone"></a> Clone\(\)

```csharp
public CMsgDOTASetMatchHistoryAccess Clone()
```

#### Returns

 [CMsgDOTASetMatchHistoryAccess](Divine.Protobufs.Dota2.CMsgDOTASetMatchHistoryAccess.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccess_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccess_Equals_Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccess_"></a> Equals\(CMsgDOTASetMatchHistoryAccess\)

```csharp
public bool Equals(CMsgDOTASetMatchHistoryAccess other)
```

#### Parameters

`other` [CMsgDOTASetMatchHistoryAccess](Divine.Protobufs.Dota2.CMsgDOTASetMatchHistoryAccess.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccess_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccess_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccess_"></a> MergeFrom\(CMsgDOTASetMatchHistoryAccess\)

```csharp
public void MergeFrom(CMsgDOTASetMatchHistoryAccess other)
```

#### Parameters

`other` [CMsgDOTASetMatchHistoryAccess](Divine.Protobufs.Dota2.CMsgDOTASetMatchHistoryAccess.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccess_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccess_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccess_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

