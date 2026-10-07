# <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy"></a> Class CMsgMatchDiretideCandy

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgMatchDiretideCandy : IMessage<CMsgMatchDiretideCandy>, IEquatable<CMsgMatchDiretideCandy>, IDeepCloneable<CMsgMatchDiretideCandy>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgMatchDiretideCandy](Divine.Protobufs.Dota2.CMsgMatchDiretideCandy.md)

#### Implements

IMessage<CMsgMatchDiretideCandy\>, 
[IEquatable<CMsgMatchDiretideCandy\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgMatchDiretideCandy\>, 
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
[EnumerableExtensions.In<CMsgMatchDiretideCandy\>\(CMsgMatchDiretideCandy, params CMsgMatchDiretideCandy\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy__ctor"></a> CMsgMatchDiretideCandy\(\)

```csharp
public CMsgMatchDiretideCandy()
```

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy__ctor_Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_"></a> CMsgMatchDiretideCandy\(CMsgMatchDiretideCandy\)

```csharp
public CMsgMatchDiretideCandy(CMsgMatchDiretideCandy other)
```

#### Parameters

`other` [CMsgMatchDiretideCandy](Divine.Protobufs.Dota2.CMsgMatchDiretideCandy.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_PlayerCandyDataFieldNumber"></a> PlayerCandyDataFieldNumber

```csharp
public const int PlayerCandyDataFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_Parser"></a> Parser

```csharp
public static MessageParser<CMsgMatchDiretideCandy> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgMatchDiretideCandy](Divine.Protobufs.Dota2.CMsgMatchDiretideCandy.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_PlayerCandyData"></a> PlayerCandyData

```csharp
public RepeatedField<CMsgMatchDiretideCandy.Types.PlayerCandy> PlayerCandyData { get; }
```

#### Property Value

 RepeatedField<[CMsgMatchDiretideCandy](Divine.Protobufs.Dota2.CMsgMatchDiretideCandy.md).[Types](Divine.Protobufs.Dota2.CMsgMatchDiretideCandy.Types.md).[PlayerCandy](Divine.Protobufs.Dota2.CMsgMatchDiretideCandy.Types.PlayerCandy.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_Clone"></a> Clone\(\)

```csharp
public CMsgMatchDiretideCandy Clone()
```

#### Returns

 [CMsgMatchDiretideCandy](Divine.Protobufs.Dota2.CMsgMatchDiretideCandy.md)

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_Equals_Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_"></a> Equals\(CMsgMatchDiretideCandy\)

```csharp
public bool Equals(CMsgMatchDiretideCandy other)
```

#### Parameters

`other` [CMsgMatchDiretideCandy](Divine.Protobufs.Dota2.CMsgMatchDiretideCandy.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_MergeFrom_Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_"></a> MergeFrom\(CMsgMatchDiretideCandy\)

```csharp
public void MergeFrom(CMsgMatchDiretideCandy other)
```

#### Parameters

`other` [CMsgMatchDiretideCandy](Divine.Protobufs.Dota2.CMsgMatchDiretideCandy.md)

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

