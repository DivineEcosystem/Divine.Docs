# <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_UserFeed"></a> Class CMsgShowcaseItem\_UserFeed

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgShowcaseItem_UserFeed : IMessage<CMsgShowcaseItem_UserFeed>, IEquatable<CMsgShowcaseItem_UserFeed>, IDeepCloneable<CMsgShowcaseItem_UserFeed>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgShowcaseItem\_UserFeed](Divine.Protobufs.Dota2.CMsgShowcaseItem\_UserFeed.md)

#### Implements

IMessage<CMsgShowcaseItem\_UserFeed\>, 
[IEquatable<CMsgShowcaseItem\_UserFeed\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgShowcaseItem\_UserFeed\>, 
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
[EnumerableExtensions.In<CMsgShowcaseItem\_UserFeed\>\(CMsgShowcaseItem\_UserFeed, params CMsgShowcaseItem\_UserFeed\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_UserFeed__ctor"></a> CMsgShowcaseItem\_UserFeed\(\)

```csharp
public CMsgShowcaseItem_UserFeed()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_UserFeed__ctor_Divine_Protobufs_Dota2_CMsgShowcaseItem_UserFeed_"></a> CMsgShowcaseItem\_UserFeed\(CMsgShowcaseItem\_UserFeed\)

```csharp
public CMsgShowcaseItem_UserFeed(CMsgShowcaseItem_UserFeed other)
```

#### Parameters

`other` [CMsgShowcaseItem\_UserFeed](Divine.Protobufs.Dota2.CMsgShowcaseItem\_UserFeed.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_UserFeed_DataFieldNumber"></a> DataFieldNumber

```csharp
public const int DataFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_UserFeed_Data"></a> Data

```csharp
public CMsgShowcaseItem_UserFeed.Types.Data Data { get; set; }
```

#### Property Value

 [CMsgShowcaseItem\_UserFeed](Divine.Protobufs.Dota2.CMsgShowcaseItem\_UserFeed.md).[Types](Divine.Protobufs.Dota2.CMsgShowcaseItem\_UserFeed.Types.md).[Data](Divine.Protobufs.Dota2.CMsgShowcaseItem\_UserFeed.Types.Data.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_UserFeed_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_UserFeed_Parser"></a> Parser

```csharp
public static MessageParser<CMsgShowcaseItem_UserFeed> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgShowcaseItem\_UserFeed](Divine.Protobufs.Dota2.CMsgShowcaseItem\_UserFeed.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_UserFeed_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_UserFeed_Clone"></a> Clone\(\)

```csharp
public CMsgShowcaseItem_UserFeed Clone()
```

#### Returns

 [CMsgShowcaseItem\_UserFeed](Divine.Protobufs.Dota2.CMsgShowcaseItem\_UserFeed.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_UserFeed_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_UserFeed_Equals_Divine_Protobufs_Dota2_CMsgShowcaseItem_UserFeed_"></a> Equals\(CMsgShowcaseItem\_UserFeed\)

```csharp
public bool Equals(CMsgShowcaseItem_UserFeed other)
```

#### Parameters

`other` [CMsgShowcaseItem\_UserFeed](Divine.Protobufs.Dota2.CMsgShowcaseItem\_UserFeed.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_UserFeed_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_UserFeed_MergeFrom_Divine_Protobufs_Dota2_CMsgShowcaseItem_UserFeed_"></a> MergeFrom\(CMsgShowcaseItem\_UserFeed\)

```csharp
public void MergeFrom(CMsgShowcaseItem_UserFeed other)
```

#### Parameters

`other` [CMsgShowcaseItem\_UserFeed](Divine.Protobufs.Dota2.CMsgShowcaseItem\_UserFeed.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_UserFeed_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_UserFeed_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_UserFeed_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

