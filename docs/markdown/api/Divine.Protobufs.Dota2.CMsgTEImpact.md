# <a id="Divine_Protobufs_Dota2_CMsgTEImpact"></a> Class CMsgTEImpact

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgTEImpact : IMessage<CMsgTEImpact>, IEquatable<CMsgTEImpact>, IDeepCloneable<CMsgTEImpact>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgTEImpact](Divine.Protobufs.Dota2.CMsgTEImpact.md)

#### Implements

IMessage<CMsgTEImpact\>, 
[IEquatable<CMsgTEImpact\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgTEImpact\>, 
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
[EnumerableExtensions.In<CMsgTEImpact\>\(CMsgTEImpact, params CMsgTEImpact\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgTEImpact__ctor"></a> CMsgTEImpact\(\)

```csharp
public CMsgTEImpact()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEImpact__ctor_Divine_Protobufs_Dota2_CMsgTEImpact_"></a> CMsgTEImpact\(CMsgTEImpact\)

```csharp
public CMsgTEImpact(CMsgTEImpact other)
```

#### Parameters

`other` [CMsgTEImpact](Divine.Protobufs.Dota2.CMsgTEImpact.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgTEImpact_NormalFieldNumber"></a> NormalFieldNumber

```csharp
public const int NormalFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEImpact_OriginFieldNumber"></a> OriginFieldNumber

```csharp
public const int OriginFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEImpact_TypeFieldNumber"></a> TypeFieldNumber

```csharp
public const int TypeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgTEImpact_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgTEImpact_HasType"></a> HasType

```csharp
public bool HasType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEImpact_Normal"></a> Normal

```csharp
public CMsgVector Normal { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEImpact_Origin"></a> Origin

```csharp
public CMsgVector Origin { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEImpact_Parser"></a> Parser

```csharp
public static MessageParser<CMsgTEImpact> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgTEImpact](Divine.Protobufs.Dota2.CMsgTEImpact.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgTEImpact_Type"></a> Type

```csharp
public uint Type { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgTEImpact_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEImpact_ClearType"></a> ClearType\(\)

```csharp
public void ClearType()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEImpact_Clone"></a> Clone\(\)

```csharp
public CMsgTEImpact Clone()
```

#### Returns

 [CMsgTEImpact](Divine.Protobufs.Dota2.CMsgTEImpact.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEImpact_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEImpact_Equals_Divine_Protobufs_Dota2_CMsgTEImpact_"></a> Equals\(CMsgTEImpact\)

```csharp
public bool Equals(CMsgTEImpact other)
```

#### Parameters

`other` [CMsgTEImpact](Divine.Protobufs.Dota2.CMsgTEImpact.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEImpact_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEImpact_MergeFrom_Divine_Protobufs_Dota2_CMsgTEImpact_"></a> MergeFrom\(CMsgTEImpact\)

```csharp
public void MergeFrom(CMsgTEImpact other)
```

#### Parameters

`other` [CMsgTEImpact](Divine.Protobufs.Dota2.CMsgTEImpact.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEImpact_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgTEImpact_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTEImpact_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

