# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MarsArenaOfBloodAttack"></a> Class CDOTAUserMsg\_MarsArenaOfBloodAttack

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_MarsArenaOfBloodAttack : IMessage<CDOTAUserMsg_MarsArenaOfBloodAttack>, IEquatable<CDOTAUserMsg_MarsArenaOfBloodAttack>, IDeepCloneable<CDOTAUserMsg_MarsArenaOfBloodAttack>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_MarsArenaOfBloodAttack](Divine.Protobufs.Dota2.CDOTAUserMsg\_MarsArenaOfBloodAttack.md)

#### Implements

IMessage<CDOTAUserMsg\_MarsArenaOfBloodAttack\>, 
[IEquatable<CDOTAUserMsg\_MarsArenaOfBloodAttack\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_MarsArenaOfBloodAttack\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_MarsArenaOfBloodAttack\>\(CDOTAUserMsg\_MarsArenaOfBloodAttack, params CDOTAUserMsg\_MarsArenaOfBloodAttack\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MarsArenaOfBloodAttack__ctor"></a> CDOTAUserMsg\_MarsArenaOfBloodAttack\(\)

```csharp
public CDOTAUserMsg_MarsArenaOfBloodAttack()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MarsArenaOfBloodAttack__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_MarsArenaOfBloodAttack_"></a> CDOTAUserMsg\_MarsArenaOfBloodAttack\(CDOTAUserMsg\_MarsArenaOfBloodAttack\)

```csharp
public CDOTAUserMsg_MarsArenaOfBloodAttack(CDOTAUserMsg_MarsArenaOfBloodAttack other)
```

#### Parameters

`other` [CDOTAUserMsg\_MarsArenaOfBloodAttack](Divine.Protobufs.Dota2.CDOTAUserMsg\_MarsArenaOfBloodAttack.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MarsArenaOfBloodAttack_SourceEhandleFieldNumber"></a> SourceEhandleFieldNumber

```csharp
public const int SourceEhandleFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MarsArenaOfBloodAttack_TargetEhandleFieldNumber"></a> TargetEhandleFieldNumber

```csharp
public const int TargetEhandleFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MarsArenaOfBloodAttack_WarriorIndexFieldNumber"></a> WarriorIndexFieldNumber

```csharp
public const int WarriorIndexFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MarsArenaOfBloodAttack_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MarsArenaOfBloodAttack_HasSourceEhandle"></a> HasSourceEhandle

```csharp
public bool HasSourceEhandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MarsArenaOfBloodAttack_HasTargetEhandle"></a> HasTargetEhandle

```csharp
public bool HasTargetEhandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MarsArenaOfBloodAttack_HasWarriorIndex"></a> HasWarriorIndex

```csharp
public bool HasWarriorIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MarsArenaOfBloodAttack_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_MarsArenaOfBloodAttack> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_MarsArenaOfBloodAttack](Divine.Protobufs.Dota2.CDOTAUserMsg\_MarsArenaOfBloodAttack.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MarsArenaOfBloodAttack_SourceEhandle"></a> SourceEhandle

```csharp
public uint SourceEhandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MarsArenaOfBloodAttack_TargetEhandle"></a> TargetEhandle

```csharp
public uint TargetEhandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MarsArenaOfBloodAttack_WarriorIndex"></a> WarriorIndex

```csharp
public int WarriorIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MarsArenaOfBloodAttack_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MarsArenaOfBloodAttack_ClearSourceEhandle"></a> ClearSourceEhandle\(\)

```csharp
public void ClearSourceEhandle()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MarsArenaOfBloodAttack_ClearTargetEhandle"></a> ClearTargetEhandle\(\)

```csharp
public void ClearTargetEhandle()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MarsArenaOfBloodAttack_ClearWarriorIndex"></a> ClearWarriorIndex\(\)

```csharp
public void ClearWarriorIndex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MarsArenaOfBloodAttack_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_MarsArenaOfBloodAttack Clone()
```

#### Returns

 [CDOTAUserMsg\_MarsArenaOfBloodAttack](Divine.Protobufs.Dota2.CDOTAUserMsg\_MarsArenaOfBloodAttack.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MarsArenaOfBloodAttack_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MarsArenaOfBloodAttack_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_MarsArenaOfBloodAttack_"></a> Equals\(CDOTAUserMsg\_MarsArenaOfBloodAttack\)

```csharp
public bool Equals(CDOTAUserMsg_MarsArenaOfBloodAttack other)
```

#### Parameters

`other` [CDOTAUserMsg\_MarsArenaOfBloodAttack](Divine.Protobufs.Dota2.CDOTAUserMsg\_MarsArenaOfBloodAttack.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MarsArenaOfBloodAttack_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MarsArenaOfBloodAttack_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_MarsArenaOfBloodAttack_"></a> MergeFrom\(CDOTAUserMsg\_MarsArenaOfBloodAttack\)

```csharp
public void MergeFrom(CDOTAUserMsg_MarsArenaOfBloodAttack other)
```

#### Parameters

`other` [CDOTAUserMsg\_MarsArenaOfBloodAttack](Divine.Protobufs.Dota2.CDOTAUserMsg\_MarsArenaOfBloodAttack.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MarsArenaOfBloodAttack_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MarsArenaOfBloodAttack_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MarsArenaOfBloodAttack_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

