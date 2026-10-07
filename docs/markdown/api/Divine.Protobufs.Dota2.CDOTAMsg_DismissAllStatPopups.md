# <a id="Divine_Protobufs_Dota2_CDOTAMsg_DismissAllStatPopups"></a> Class CDOTAMsg\_DismissAllStatPopups

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAMsg_DismissAllStatPopups : IMessage<CDOTAMsg_DismissAllStatPopups>, IEquatable<CDOTAMsg_DismissAllStatPopups>, IDeepCloneable<CDOTAMsg_DismissAllStatPopups>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAMsg\_DismissAllStatPopups](Divine.Protobufs.Dota2.CDOTAMsg\_DismissAllStatPopups.md)

#### Implements

IMessage<CDOTAMsg\_DismissAllStatPopups\>, 
[IEquatable<CDOTAMsg\_DismissAllStatPopups\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAMsg\_DismissAllStatPopups\>, 
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
[EnumerableExtensions.In<CDOTAMsg\_DismissAllStatPopups\>\(CDOTAMsg\_DismissAllStatPopups, params CDOTAMsg\_DismissAllStatPopups\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_DismissAllStatPopups__ctor"></a> CDOTAMsg\_DismissAllStatPopups\(\)

```csharp
public CDOTAMsg_DismissAllStatPopups()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_DismissAllStatPopups__ctor_Divine_Protobufs_Dota2_CDOTAMsg_DismissAllStatPopups_"></a> CDOTAMsg\_DismissAllStatPopups\(CDOTAMsg\_DismissAllStatPopups\)

```csharp
public CDOTAMsg_DismissAllStatPopups(CDOTAMsg_DismissAllStatPopups other)
```

#### Parameters

`other` [CDOTAMsg\_DismissAllStatPopups](Divine.Protobufs.Dota2.CDOTAMsg\_DismissAllStatPopups.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_DismissAllStatPopups_TimeDelayFieldNumber"></a> TimeDelayFieldNumber

```csharp
public const int TimeDelayFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_DismissAllStatPopups_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_DismissAllStatPopups_HasTimeDelay"></a> HasTimeDelay

```csharp
public bool HasTimeDelay { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_DismissAllStatPopups_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAMsg_DismissAllStatPopups> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAMsg\_DismissAllStatPopups](Divine.Protobufs.Dota2.CDOTAMsg\_DismissAllStatPopups.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_DismissAllStatPopups_TimeDelay"></a> TimeDelay

```csharp
public float TimeDelay { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_DismissAllStatPopups_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_DismissAllStatPopups_ClearTimeDelay"></a> ClearTimeDelay\(\)

```csharp
public void ClearTimeDelay()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_DismissAllStatPopups_Clone"></a> Clone\(\)

```csharp
public CDOTAMsg_DismissAllStatPopups Clone()
```

#### Returns

 [CDOTAMsg\_DismissAllStatPopups](Divine.Protobufs.Dota2.CDOTAMsg\_DismissAllStatPopups.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_DismissAllStatPopups_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_DismissAllStatPopups_Equals_Divine_Protobufs_Dota2_CDOTAMsg_DismissAllStatPopups_"></a> Equals\(CDOTAMsg\_DismissAllStatPopups\)

```csharp
public bool Equals(CDOTAMsg_DismissAllStatPopups other)
```

#### Parameters

`other` [CDOTAMsg\_DismissAllStatPopups](Divine.Protobufs.Dota2.CDOTAMsg\_DismissAllStatPopups.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_DismissAllStatPopups_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_DismissAllStatPopups_MergeFrom_Divine_Protobufs_Dota2_CDOTAMsg_DismissAllStatPopups_"></a> MergeFrom\(CDOTAMsg\_DismissAllStatPopups\)

```csharp
public void MergeFrom(CDOTAMsg_DismissAllStatPopups other)
```

#### Parameters

`other` [CDOTAMsg\_DismissAllStatPopups](Divine.Protobufs.Dota2.CDOTAMsg\_DismissAllStatPopups.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_DismissAllStatPopups_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_DismissAllStatPopups_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_DismissAllStatPopups_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

