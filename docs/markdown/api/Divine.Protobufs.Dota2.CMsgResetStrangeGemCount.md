# <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCount"></a> Class CMsgResetStrangeGemCount

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgResetStrangeGemCount : IMessage<CMsgResetStrangeGemCount>, IEquatable<CMsgResetStrangeGemCount>, IDeepCloneable<CMsgResetStrangeGemCount>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgResetStrangeGemCount](Divine.Protobufs.Dota2.CMsgResetStrangeGemCount.md)

#### Implements

IMessage<CMsgResetStrangeGemCount\>, 
[IEquatable<CMsgResetStrangeGemCount\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgResetStrangeGemCount\>, 
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
[EnumerableExtensions.In<CMsgResetStrangeGemCount\>\(CMsgResetStrangeGemCount, params CMsgResetStrangeGemCount\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCount__ctor"></a> CMsgResetStrangeGemCount\(\)

```csharp
public CMsgResetStrangeGemCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCount__ctor_Divine_Protobufs_Dota2_CMsgResetStrangeGemCount_"></a> CMsgResetStrangeGemCount\(CMsgResetStrangeGemCount\)

```csharp
public CMsgResetStrangeGemCount(CMsgResetStrangeGemCount other)
```

#### Parameters

`other` [CMsgResetStrangeGemCount](Divine.Protobufs.Dota2.CMsgResetStrangeGemCount.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCount_ItemItemIdFieldNumber"></a> ItemItemIdFieldNumber

```csharp
public const int ItemItemIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCount_SocketIndexFieldNumber"></a> SocketIndexFieldNumber

```csharp
public const int SocketIndexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCount_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCount_HasItemItemId"></a> HasItemItemId

```csharp
public bool HasItemItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCount_HasSocketIndex"></a> HasSocketIndex

```csharp
public bool HasSocketIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCount_ItemItemId"></a> ItemItemId

```csharp
public ulong ItemItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCount_Parser"></a> Parser

```csharp
public static MessageParser<CMsgResetStrangeGemCount> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgResetStrangeGemCount](Divine.Protobufs.Dota2.CMsgResetStrangeGemCount.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCount_SocketIndex"></a> SocketIndex

```csharp
public uint SocketIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCount_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCount_ClearItemItemId"></a> ClearItemItemId\(\)

```csharp
public void ClearItemItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCount_ClearSocketIndex"></a> ClearSocketIndex\(\)

```csharp
public void ClearSocketIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCount_Clone"></a> Clone\(\)

```csharp
public CMsgResetStrangeGemCount Clone()
```

#### Returns

 [CMsgResetStrangeGemCount](Divine.Protobufs.Dota2.CMsgResetStrangeGemCount.md)

### <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCount_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCount_Equals_Divine_Protobufs_Dota2_CMsgResetStrangeGemCount_"></a> Equals\(CMsgResetStrangeGemCount\)

```csharp
public bool Equals(CMsgResetStrangeGemCount other)
```

#### Parameters

`other` [CMsgResetStrangeGemCount](Divine.Protobufs.Dota2.CMsgResetStrangeGemCount.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCount_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCount_MergeFrom_Divine_Protobufs_Dota2_CMsgResetStrangeGemCount_"></a> MergeFrom\(CMsgResetStrangeGemCount\)

```csharp
public void MergeFrom(CMsgResetStrangeGemCount other)
```

#### Parameters

`other` [CMsgResetStrangeGemCount](Divine.Protobufs.Dota2.CMsgResetStrangeGemCount.md)

### <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCount_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCount_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCount_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

