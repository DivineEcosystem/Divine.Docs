# <a id="Divine_Protobufs_Dota2_CMsgDOTADPCFeed"></a> Class CMsgDOTADPCFeed

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTADPCFeed : IMessage<CMsgDOTADPCFeed>, IEquatable<CMsgDOTADPCFeed>, IDeepCloneable<CMsgDOTADPCFeed>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTADPCFeed](Divine.Protobufs.Dota2.CMsgDOTADPCFeed.md)

#### Implements

IMessage<CMsgDOTADPCFeed\>, 
[IEquatable<CMsgDOTADPCFeed\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTADPCFeed\>, 
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
[EnumerableExtensions.In<CMsgDOTADPCFeed\>\(CMsgDOTADPCFeed, params CMsgDOTADPCFeed\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCFeed__ctor"></a> CMsgDOTADPCFeed\(\)

```csharp
public CMsgDOTADPCFeed()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCFeed__ctor_Divine_Protobufs_Dota2_CMsgDOTADPCFeed_"></a> CMsgDOTADPCFeed\(CMsgDOTADPCFeed\)

```csharp
public CMsgDOTADPCFeed(CMsgDOTADPCFeed other)
```

#### Parameters

`other` [CMsgDOTADPCFeed](Divine.Protobufs.Dota2.CMsgDOTADPCFeed.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCFeed_ElementsFieldNumber"></a> ElementsFieldNumber

```csharp
public const int ElementsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCFeed_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCFeed_Elements"></a> Elements

```csharp
public RepeatedField<CMsgDOTADPCFeed.Types.Element> Elements { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTADPCFeed](Divine.Protobufs.Dota2.CMsgDOTADPCFeed.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCFeed.Types.md).[Element](Divine.Protobufs.Dota2.CMsgDOTADPCFeed.Types.Element.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCFeed_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTADPCFeed> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTADPCFeed](Divine.Protobufs.Dota2.CMsgDOTADPCFeed.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCFeed_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCFeed_Clone"></a> Clone\(\)

```csharp
public CMsgDOTADPCFeed Clone()
```

#### Returns

 [CMsgDOTADPCFeed](Divine.Protobufs.Dota2.CMsgDOTADPCFeed.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCFeed_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCFeed_Equals_Divine_Protobufs_Dota2_CMsgDOTADPCFeed_"></a> Equals\(CMsgDOTADPCFeed\)

```csharp
public bool Equals(CMsgDOTADPCFeed other)
```

#### Parameters

`other` [CMsgDOTADPCFeed](Divine.Protobufs.Dota2.CMsgDOTADPCFeed.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCFeed_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCFeed_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTADPCFeed_"></a> MergeFrom\(CMsgDOTADPCFeed\)

```csharp
public void MergeFrom(CMsgDOTADPCFeed other)
```

#### Parameters

`other` [CMsgDOTADPCFeed](Divine.Protobufs.Dota2.CMsgDOTADPCFeed.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCFeed_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCFeed_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCFeed_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

