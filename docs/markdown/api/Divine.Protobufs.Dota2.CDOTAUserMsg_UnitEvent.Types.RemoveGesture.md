# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_RemoveGesture"></a> Class CDOTAUserMsg\_UnitEvent.Types.RemoveGesture

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_UnitEvent.Types.RemoveGesture : IMessage<CDOTAUserMsg_UnitEvent.Types.RemoveGesture>, IEquatable<CDOTAUserMsg_UnitEvent.Types.RemoveGesture>, IDeepCloneable<CDOTAUserMsg_UnitEvent.Types.RemoveGesture>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_UnitEvent.Types.RemoveGesture](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.RemoveGesture.md)

#### Implements

IMessage<CDOTAUserMsg\_UnitEvent.Types.RemoveGesture\>, 
[IEquatable<CDOTAUserMsg\_UnitEvent.Types.RemoveGesture\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_UnitEvent.Types.RemoveGesture\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_UnitEvent.Types.RemoveGesture\>\(CDOTAUserMsg\_UnitEvent.Types.RemoveGesture, params CDOTAUserMsg\_UnitEvent.Types.RemoveGesture\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_RemoveGesture__ctor"></a> RemoveGesture\(\)

```csharp
public RemoveGesture()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_RemoveGesture__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_RemoveGesture_"></a> RemoveGesture\(RemoveGesture\)

```csharp
public RemoveGesture(CDOTAUserMsg_UnitEvent.Types.RemoveGesture other)
```

#### Parameters

`other` [CDOTAUserMsg\_UnitEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.md).[RemoveGesture](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.RemoveGesture.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_RemoveGesture_ActivityFieldNumber"></a> ActivityFieldNumber

```csharp
public const int ActivityFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_RemoveGesture_Activity"></a> Activity

```csharp
public int Activity { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_RemoveGesture_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_RemoveGesture_HasActivity"></a> HasActivity

```csharp
public bool HasActivity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_RemoveGesture_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_UnitEvent.Types.RemoveGesture> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_UnitEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.md).[RemoveGesture](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.RemoveGesture.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_RemoveGesture_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_RemoveGesture_ClearActivity"></a> ClearActivity\(\)

```csharp
public void ClearActivity()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_RemoveGesture_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_UnitEvent.Types.RemoveGesture Clone()
```

#### Returns

 [CDOTAUserMsg\_UnitEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.md).[RemoveGesture](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.RemoveGesture.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_RemoveGesture_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_RemoveGesture_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_RemoveGesture_"></a> Equals\(RemoveGesture\)

```csharp
public bool Equals(CDOTAUserMsg_UnitEvent.Types.RemoveGesture other)
```

#### Parameters

`other` [CDOTAUserMsg\_UnitEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.md).[RemoveGesture](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.RemoveGesture.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_RemoveGesture_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_RemoveGesture_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_RemoveGesture_"></a> MergeFrom\(RemoveGesture\)

```csharp
public void MergeFrom(CDOTAUserMsg_UnitEvent.Types.RemoveGesture other)
```

#### Parameters

`other` [CDOTAUserMsg\_UnitEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.md).[RemoveGesture](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.RemoveGesture.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_RemoveGesture_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_RemoveGesture_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_RemoveGesture_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

