# <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_ChatWheel"></a> Class CMsgShowcaseItem\_ChatWheel

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgShowcaseItem_ChatWheel : IMessage<CMsgShowcaseItem_ChatWheel>, IEquatable<CMsgShowcaseItem_ChatWheel>, IDeepCloneable<CMsgShowcaseItem_ChatWheel>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgShowcaseItem\_ChatWheel](Divine.Protobufs.Dota2.CMsgShowcaseItem\_ChatWheel.md)

#### Implements

IMessage<CMsgShowcaseItem\_ChatWheel\>, 
[IEquatable<CMsgShowcaseItem\_ChatWheel\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgShowcaseItem\_ChatWheel\>, 
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
[EnumerableExtensions.In<CMsgShowcaseItem\_ChatWheel\>\(CMsgShowcaseItem\_ChatWheel, params CMsgShowcaseItem\_ChatWheel\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_ChatWheel__ctor"></a> CMsgShowcaseItem\_ChatWheel\(\)

```csharp
public CMsgShowcaseItem_ChatWheel()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_ChatWheel__ctor_Divine_Protobufs_Dota2_CMsgShowcaseItem_ChatWheel_"></a> CMsgShowcaseItem\_ChatWheel\(CMsgShowcaseItem\_ChatWheel\)

```csharp
public CMsgShowcaseItem_ChatWheel(CMsgShowcaseItem_ChatWheel other)
```

#### Parameters

`other` [CMsgShowcaseItem\_ChatWheel](Divine.Protobufs.Dota2.CMsgShowcaseItem\_ChatWheel.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_ChatWheel_ChatWheelMessageIdFieldNumber"></a> ChatWheelMessageIdFieldNumber

```csharp
public const int ChatWheelMessageIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_ChatWheel_DataFieldNumber"></a> DataFieldNumber

```csharp
public const int DataFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_ChatWheel_ChatWheelMessageId"></a> ChatWheelMessageId

```csharp
public uint ChatWheelMessageId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_ChatWheel_Data"></a> Data

```csharp
public CMsgShowcaseItem_ChatWheel.Types.Data Data { get; set; }
```

#### Property Value

 [CMsgShowcaseItem\_ChatWheel](Divine.Protobufs.Dota2.CMsgShowcaseItem\_ChatWheel.md).[Types](Divine.Protobufs.Dota2.CMsgShowcaseItem\_ChatWheel.Types.md).[Data](Divine.Protobufs.Dota2.CMsgShowcaseItem\_ChatWheel.Types.Data.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_ChatWheel_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_ChatWheel_HasChatWheelMessageId"></a> HasChatWheelMessageId

```csharp
public bool HasChatWheelMessageId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_ChatWheel_Parser"></a> Parser

```csharp
public static MessageParser<CMsgShowcaseItem_ChatWheel> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgShowcaseItem\_ChatWheel](Divine.Protobufs.Dota2.CMsgShowcaseItem\_ChatWheel.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_ChatWheel_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_ChatWheel_ClearChatWheelMessageId"></a> ClearChatWheelMessageId\(\)

```csharp
public void ClearChatWheelMessageId()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_ChatWheel_Clone"></a> Clone\(\)

```csharp
public CMsgShowcaseItem_ChatWheel Clone()
```

#### Returns

 [CMsgShowcaseItem\_ChatWheel](Divine.Protobufs.Dota2.CMsgShowcaseItem\_ChatWheel.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_ChatWheel_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_ChatWheel_Equals_Divine_Protobufs_Dota2_CMsgShowcaseItem_ChatWheel_"></a> Equals\(CMsgShowcaseItem\_ChatWheel\)

```csharp
public bool Equals(CMsgShowcaseItem_ChatWheel other)
```

#### Parameters

`other` [CMsgShowcaseItem\_ChatWheel](Divine.Protobufs.Dota2.CMsgShowcaseItem\_ChatWheel.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_ChatWheel_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_ChatWheel_MergeFrom_Divine_Protobufs_Dota2_CMsgShowcaseItem_ChatWheel_"></a> MergeFrom\(CMsgShowcaseItem\_ChatWheel\)

```csharp
public void MergeFrom(CMsgShowcaseItem_ChatWheel other)
```

#### Parameters

`other` [CMsgShowcaseItem\_ChatWheel](Divine.Protobufs.Dota2.CMsgShowcaseItem\_ChatWheel.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_ChatWheel_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_ChatWheel_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_ChatWheel_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

