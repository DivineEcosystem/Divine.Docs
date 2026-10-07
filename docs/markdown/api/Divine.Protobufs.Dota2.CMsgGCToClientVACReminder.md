# <a id="Divine_Protobufs_Dota2_CMsgGCToClientVACReminder"></a> Class CMsgGCToClientVACReminder

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientVACReminder : IMessage<CMsgGCToClientVACReminder>, IEquatable<CMsgGCToClientVACReminder>, IDeepCloneable<CMsgGCToClientVACReminder>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientVACReminder](Divine.Protobufs.Dota2.CMsgGCToClientVACReminder.md)

#### Implements

IMessage<CMsgGCToClientVACReminder\>, 
[IEquatable<CMsgGCToClientVACReminder\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientVACReminder\>, 
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
[EnumerableExtensions.In<CMsgGCToClientVACReminder\>\(CMsgGCToClientVACReminder, params CMsgGCToClientVACReminder\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientVACReminder__ctor"></a> CMsgGCToClientVACReminder\(\)

```csharp
public CMsgGCToClientVACReminder()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientVACReminder__ctor_Divine_Protobufs_Dota2_CMsgGCToClientVACReminder_"></a> CMsgGCToClientVACReminder\(CMsgGCToClientVACReminder\)

```csharp
public CMsgGCToClientVACReminder(CMsgGCToClientVACReminder other)
```

#### Parameters

`other` [CMsgGCToClientVACReminder](Divine.Protobufs.Dota2.CMsgGCToClientVACReminder.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientVACReminder_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientVACReminder_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientVACReminder> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientVACReminder](Divine.Protobufs.Dota2.CMsgGCToClientVACReminder.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientVACReminder_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientVACReminder_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientVACReminder Clone()
```

#### Returns

 [CMsgGCToClientVACReminder](Divine.Protobufs.Dota2.CMsgGCToClientVACReminder.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientVACReminder_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientVACReminder_Equals_Divine_Protobufs_Dota2_CMsgGCToClientVACReminder_"></a> Equals\(CMsgGCToClientVACReminder\)

```csharp
public bool Equals(CMsgGCToClientVACReminder other)
```

#### Parameters

`other` [CMsgGCToClientVACReminder](Divine.Protobufs.Dota2.CMsgGCToClientVACReminder.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientVACReminder_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientVACReminder_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientVACReminder_"></a> MergeFrom\(CMsgGCToClientVACReminder\)

```csharp
public void MergeFrom(CMsgGCToClientVACReminder other)
```

#### Parameters

`other` [CMsgGCToClientVACReminder](Divine.Protobufs.Dota2.CMsgGCToClientVACReminder.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientVACReminder_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientVACReminder_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientVACReminder_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

