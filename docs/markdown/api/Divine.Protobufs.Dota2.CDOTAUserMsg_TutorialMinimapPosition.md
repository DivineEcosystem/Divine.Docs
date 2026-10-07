# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialMinimapPosition"></a> Class CDOTAUserMsg\_TutorialMinimapPosition

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_TutorialMinimapPosition : IMessage<CDOTAUserMsg_TutorialMinimapPosition>, IEquatable<CDOTAUserMsg_TutorialMinimapPosition>, IDeepCloneable<CDOTAUserMsg_TutorialMinimapPosition>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_TutorialMinimapPosition](Divine.Protobufs.Dota2.CDOTAUserMsg\_TutorialMinimapPosition.md)

#### Implements

IMessage<CDOTAUserMsg\_TutorialMinimapPosition\>, 
[IEquatable<CDOTAUserMsg\_TutorialMinimapPosition\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_TutorialMinimapPosition\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_TutorialMinimapPosition\>\(CDOTAUserMsg\_TutorialMinimapPosition, params CDOTAUserMsg\_TutorialMinimapPosition\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialMinimapPosition__ctor"></a> CDOTAUserMsg\_TutorialMinimapPosition\(\)

```csharp
public CDOTAUserMsg_TutorialMinimapPosition()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialMinimapPosition__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialMinimapPosition_"></a> CDOTAUserMsg\_TutorialMinimapPosition\(CDOTAUserMsg\_TutorialMinimapPosition\)

```csharp
public CDOTAUserMsg_TutorialMinimapPosition(CDOTAUserMsg_TutorialMinimapPosition other)
```

#### Parameters

`other` [CDOTAUserMsg\_TutorialMinimapPosition](Divine.Protobufs.Dota2.CDOTAUserMsg\_TutorialMinimapPosition.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialMinimapPosition_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialMinimapPosition_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_TutorialMinimapPosition> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_TutorialMinimapPosition](Divine.Protobufs.Dota2.CDOTAUserMsg\_TutorialMinimapPosition.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialMinimapPosition_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialMinimapPosition_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_TutorialMinimapPosition Clone()
```

#### Returns

 [CDOTAUserMsg\_TutorialMinimapPosition](Divine.Protobufs.Dota2.CDOTAUserMsg\_TutorialMinimapPosition.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialMinimapPosition_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialMinimapPosition_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialMinimapPosition_"></a> Equals\(CDOTAUserMsg\_TutorialMinimapPosition\)

```csharp
public bool Equals(CDOTAUserMsg_TutorialMinimapPosition other)
```

#### Parameters

`other` [CDOTAUserMsg\_TutorialMinimapPosition](Divine.Protobufs.Dota2.CDOTAUserMsg\_TutorialMinimapPosition.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialMinimapPosition_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialMinimapPosition_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialMinimapPosition_"></a> MergeFrom\(CDOTAUserMsg\_TutorialMinimapPosition\)

```csharp
public void MergeFrom(CDOTAUserMsg_TutorialMinimapPosition other)
```

#### Parameters

`other` [CDOTAUserMsg\_TutorialMinimapPosition](Divine.Protobufs.Dota2.CDOTAUserMsg\_TutorialMinimapPosition.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialMinimapPosition_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialMinimapPosition_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialMinimapPosition_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

