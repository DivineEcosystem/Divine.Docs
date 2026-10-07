# <a id="Divine_Protobufs_Dota2_CBaseUserCmdExecutionNotes"></a> Class CBaseUserCmdExecutionNotes

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CBaseUserCmdExecutionNotes : IMessage<CBaseUserCmdExecutionNotes>, IEquatable<CBaseUserCmdExecutionNotes>, IDeepCloneable<CBaseUserCmdExecutionNotes>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CBaseUserCmdExecutionNotes](Divine.Protobufs.Dota2.CBaseUserCmdExecutionNotes.md)

#### Implements

IMessage<CBaseUserCmdExecutionNotes\>, 
[IEquatable<CBaseUserCmdExecutionNotes\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CBaseUserCmdExecutionNotes\>, 
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
[EnumerableExtensions.In<CBaseUserCmdExecutionNotes\>\(CBaseUserCmdExecutionNotes, params CBaseUserCmdExecutionNotes\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdExecutionNotes__ctor"></a> CBaseUserCmdExecutionNotes\(\)

```csharp
public CBaseUserCmdExecutionNotes()
```

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdExecutionNotes__ctor_Divine_Protobufs_Dota2_CBaseUserCmdExecutionNotes_"></a> CBaseUserCmdExecutionNotes\(CBaseUserCmdExecutionNotes\)

```csharp
public CBaseUserCmdExecutionNotes(CBaseUserCmdExecutionNotes other)
```

#### Parameters

`other` [CBaseUserCmdExecutionNotes](Divine.Protobufs.Dota2.CBaseUserCmdExecutionNotes.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdExecutionNotes_IgnoredReasonFieldNumber"></a> IgnoredReasonFieldNumber

```csharp
public const int IgnoredReasonFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdExecutionNotes_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdExecutionNotes_HasIgnoredReason"></a> HasIgnoredReason

```csharp
public bool HasIgnoredReason { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdExecutionNotes_IgnoredReason"></a> IgnoredReason

```csharp
public string IgnoredReason { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdExecutionNotes_Parser"></a> Parser

```csharp
public static MessageParser<CBaseUserCmdExecutionNotes> Parser { get; }
```

#### Property Value

 MessageParser<[CBaseUserCmdExecutionNotes](Divine.Protobufs.Dota2.CBaseUserCmdExecutionNotes.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdExecutionNotes_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdExecutionNotes_ClearIgnoredReason"></a> ClearIgnoredReason\(\)

```csharp
public void ClearIgnoredReason()
```

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdExecutionNotes_Clone"></a> Clone\(\)

```csharp
public CBaseUserCmdExecutionNotes Clone()
```

#### Returns

 [CBaseUserCmdExecutionNotes](Divine.Protobufs.Dota2.CBaseUserCmdExecutionNotes.md)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdExecutionNotes_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdExecutionNotes_Equals_Divine_Protobufs_Dota2_CBaseUserCmdExecutionNotes_"></a> Equals\(CBaseUserCmdExecutionNotes\)

```csharp
public bool Equals(CBaseUserCmdExecutionNotes other)
```

#### Parameters

`other` [CBaseUserCmdExecutionNotes](Divine.Protobufs.Dota2.CBaseUserCmdExecutionNotes.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdExecutionNotes_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdExecutionNotes_MergeFrom_Divine_Protobufs_Dota2_CBaseUserCmdExecutionNotes_"></a> MergeFrom\(CBaseUserCmdExecutionNotes\)

```csharp
public void MergeFrom(CBaseUserCmdExecutionNotes other)
```

#### Parameters

`other` [CBaseUserCmdExecutionNotes](Divine.Protobufs.Dota2.CBaseUserCmdExecutionNotes.md)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdExecutionNotes_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdExecutionNotes_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdExecutionNotes_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

