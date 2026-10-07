# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DismissAllStatPopups"></a> Class CDOTAUserMsg\_DismissAllStatPopups

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_DismissAllStatPopups : IMessage<CDOTAUserMsg_DismissAllStatPopups>, IEquatable<CDOTAUserMsg_DismissAllStatPopups>, IDeepCloneable<CDOTAUserMsg_DismissAllStatPopups>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_DismissAllStatPopups](Divine.Protobufs.Dota2.CDOTAUserMsg\_DismissAllStatPopups.md)

#### Implements

IMessage<CDOTAUserMsg\_DismissAllStatPopups\>, 
[IEquatable<CDOTAUserMsg\_DismissAllStatPopups\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_DismissAllStatPopups\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_DismissAllStatPopups\>\(CDOTAUserMsg\_DismissAllStatPopups, params CDOTAUserMsg\_DismissAllStatPopups\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DismissAllStatPopups__ctor"></a> CDOTAUserMsg\_DismissAllStatPopups\(\)

```csharp
public CDOTAUserMsg_DismissAllStatPopups()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DismissAllStatPopups__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_DismissAllStatPopups_"></a> CDOTAUserMsg\_DismissAllStatPopups\(CDOTAUserMsg\_DismissAllStatPopups\)

```csharp
public CDOTAUserMsg_DismissAllStatPopups(CDOTAUserMsg_DismissAllStatPopups other)
```

#### Parameters

`other` [CDOTAUserMsg\_DismissAllStatPopups](Divine.Protobufs.Dota2.CDOTAUserMsg\_DismissAllStatPopups.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DismissAllStatPopups_DismissallmsgFieldNumber"></a> DismissallmsgFieldNumber

```csharp
public const int DismissallmsgFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DismissAllStatPopups_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DismissAllStatPopups_Dismissallmsg"></a> Dismissallmsg

```csharp
public CDOTAMsg_DismissAllStatPopups Dismissallmsg { get; set; }
```

#### Property Value

 [CDOTAMsg\_DismissAllStatPopups](Divine.Protobufs.Dota2.CDOTAMsg\_DismissAllStatPopups.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DismissAllStatPopups_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_DismissAllStatPopups> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_DismissAllStatPopups](Divine.Protobufs.Dota2.CDOTAUserMsg\_DismissAllStatPopups.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DismissAllStatPopups_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DismissAllStatPopups_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_DismissAllStatPopups Clone()
```

#### Returns

 [CDOTAUserMsg\_DismissAllStatPopups](Divine.Protobufs.Dota2.CDOTAUserMsg\_DismissAllStatPopups.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DismissAllStatPopups_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DismissAllStatPopups_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_DismissAllStatPopups_"></a> Equals\(CDOTAUserMsg\_DismissAllStatPopups\)

```csharp
public bool Equals(CDOTAUserMsg_DismissAllStatPopups other)
```

#### Parameters

`other` [CDOTAUserMsg\_DismissAllStatPopups](Divine.Protobufs.Dota2.CDOTAUserMsg\_DismissAllStatPopups.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DismissAllStatPopups_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DismissAllStatPopups_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_DismissAllStatPopups_"></a> MergeFrom\(CDOTAUserMsg\_DismissAllStatPopups\)

```csharp
public void MergeFrom(CDOTAUserMsg_DismissAllStatPopups other)
```

#### Parameters

`other` [CDOTAUserMsg\_DismissAllStatPopups](Divine.Protobufs.Dota2.CDOTAUserMsg\_DismissAllStatPopups.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DismissAllStatPopups_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DismissAllStatPopups_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DismissAllStatPopups_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

