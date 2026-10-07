# <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservation"></a> Class CMsgGCItemEditorReservation

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCItemEditorReservation : IMessage<CMsgGCItemEditorReservation>, IEquatable<CMsgGCItemEditorReservation>, IDeepCloneable<CMsgGCItemEditorReservation>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCItemEditorReservation](Divine.Protobufs.Dota2.CMsgGCItemEditorReservation.md)

#### Implements

IMessage<CMsgGCItemEditorReservation\>, 
[IEquatable<CMsgGCItemEditorReservation\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCItemEditorReservation\>, 
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
[EnumerableExtensions.In<CMsgGCItemEditorReservation\>\(CMsgGCItemEditorReservation, params CMsgGCItemEditorReservation\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservation__ctor"></a> CMsgGCItemEditorReservation\(\)

```csharp
public CMsgGCItemEditorReservation()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservation__ctor_Divine_Protobufs_Dota2_CMsgGCItemEditorReservation_"></a> CMsgGCItemEditorReservation\(CMsgGCItemEditorReservation\)

```csharp
public CMsgGCItemEditorReservation(CMsgGCItemEditorReservation other)
```

#### Parameters

`other` [CMsgGCItemEditorReservation](Divine.Protobufs.Dota2.CMsgGCItemEditorReservation.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservation_DefIndexFieldNumber"></a> DefIndexFieldNumber

```csharp
public const int DefIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservation_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservation_DefIndex"></a> DefIndex

```csharp
public uint DefIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservation_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservation_HasDefIndex"></a> HasDefIndex

```csharp
public bool HasDefIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservation_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservation_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservation_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCItemEditorReservation> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCItemEditorReservation](Divine.Protobufs.Dota2.CMsgGCItemEditorReservation.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservation_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservation_ClearDefIndex"></a> ClearDefIndex\(\)

```csharp
public void ClearDefIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservation_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservation_Clone"></a> Clone\(\)

```csharp
public CMsgGCItemEditorReservation Clone()
```

#### Returns

 [CMsgGCItemEditorReservation](Divine.Protobufs.Dota2.CMsgGCItemEditorReservation.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservation_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservation_Equals_Divine_Protobufs_Dota2_CMsgGCItemEditorReservation_"></a> Equals\(CMsgGCItemEditorReservation\)

```csharp
public bool Equals(CMsgGCItemEditorReservation other)
```

#### Parameters

`other` [CMsgGCItemEditorReservation](Divine.Protobufs.Dota2.CMsgGCItemEditorReservation.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservation_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservation_MergeFrom_Divine_Protobufs_Dota2_CMsgGCItemEditorReservation_"></a> MergeFrom\(CMsgGCItemEditorReservation\)

```csharp
public void MergeFrom(CMsgGCItemEditorReservation other)
```

#### Parameters

`other` [CMsgGCItemEditorReservation](Divine.Protobufs.Dota2.CMsgGCItemEditorReservation.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservation_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservation_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservation_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

