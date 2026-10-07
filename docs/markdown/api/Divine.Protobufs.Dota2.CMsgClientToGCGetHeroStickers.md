# <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetHeroStickers"></a> Class CMsgClientToGCGetHeroStickers

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCGetHeroStickers : IMessage<CMsgClientToGCGetHeroStickers>, IEquatable<CMsgClientToGCGetHeroStickers>, IDeepCloneable<CMsgClientToGCGetHeroStickers>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCGetHeroStickers](Divine.Protobufs.Dota2.CMsgClientToGCGetHeroStickers.md)

#### Implements

IMessage<CMsgClientToGCGetHeroStickers\>, 
[IEquatable<CMsgClientToGCGetHeroStickers\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCGetHeroStickers\>, 
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
[EnumerableExtensions.In<CMsgClientToGCGetHeroStickers\>\(CMsgClientToGCGetHeroStickers, params CMsgClientToGCGetHeroStickers\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetHeroStickers__ctor"></a> CMsgClientToGCGetHeroStickers\(\)

```csharp
public CMsgClientToGCGetHeroStickers()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetHeroStickers__ctor_Divine_Protobufs_Dota2_CMsgClientToGCGetHeroStickers_"></a> CMsgClientToGCGetHeroStickers\(CMsgClientToGCGetHeroStickers\)

```csharp
public CMsgClientToGCGetHeroStickers(CMsgClientToGCGetHeroStickers other)
```

#### Parameters

`other` [CMsgClientToGCGetHeroStickers](Divine.Protobufs.Dota2.CMsgClientToGCGetHeroStickers.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetHeroStickers_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetHeroStickers_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCGetHeroStickers> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCGetHeroStickers](Divine.Protobufs.Dota2.CMsgClientToGCGetHeroStickers.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetHeroStickers_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetHeroStickers_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCGetHeroStickers Clone()
```

#### Returns

 [CMsgClientToGCGetHeroStickers](Divine.Protobufs.Dota2.CMsgClientToGCGetHeroStickers.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetHeroStickers_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetHeroStickers_Equals_Divine_Protobufs_Dota2_CMsgClientToGCGetHeroStickers_"></a> Equals\(CMsgClientToGCGetHeroStickers\)

```csharp
public bool Equals(CMsgClientToGCGetHeroStickers other)
```

#### Parameters

`other` [CMsgClientToGCGetHeroStickers](Divine.Protobufs.Dota2.CMsgClientToGCGetHeroStickers.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetHeroStickers_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetHeroStickers_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCGetHeroStickers_"></a> MergeFrom\(CMsgClientToGCGetHeroStickers\)

```csharp
public void MergeFrom(CMsgClientToGCGetHeroStickers other)
```

#### Parameters

`other` [CMsgClientToGCGetHeroStickers](Divine.Protobufs.Dota2.CMsgClientToGCGetHeroStickers.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetHeroStickers_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetHeroStickers_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetHeroStickers_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

