# <a id="Divine_Protobufs_Dota2_CDOTALuaModifierEntry"></a> Class CDOTALuaModifierEntry

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTALuaModifierEntry : IMessage<CDOTALuaModifierEntry>, IEquatable<CDOTALuaModifierEntry>, IDeepCloneable<CDOTALuaModifierEntry>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTALuaModifierEntry](Divine.Protobufs.Dota2.CDOTALuaModifierEntry.md)

#### Implements

IMessage<CDOTALuaModifierEntry\>, 
[IEquatable<CDOTALuaModifierEntry\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTALuaModifierEntry\>, 
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
[EnumerableExtensions.In<CDOTALuaModifierEntry\>\(CDOTALuaModifierEntry, params CDOTALuaModifierEntry\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTALuaModifierEntry__ctor"></a> CDOTALuaModifierEntry\(\)

```csharp
public CDOTALuaModifierEntry()
```

### <a id="Divine_Protobufs_Dota2_CDOTALuaModifierEntry__ctor_Divine_Protobufs_Dota2_CDOTALuaModifierEntry_"></a> CDOTALuaModifierEntry\(CDOTALuaModifierEntry\)

```csharp
public CDOTALuaModifierEntry(CDOTALuaModifierEntry other)
```

#### Parameters

`other` [CDOTALuaModifierEntry](Divine.Protobufs.Dota2.CDOTALuaModifierEntry.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTALuaModifierEntry_ModifierFilenameFieldNumber"></a> ModifierFilenameFieldNumber

```csharp
public const int ModifierFilenameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTALuaModifierEntry_ModifierTypeFieldNumber"></a> ModifierTypeFieldNumber

```csharp
public const int ModifierTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTALuaModifierEntry_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTALuaModifierEntry_HasModifierFilename"></a> HasModifierFilename

```csharp
public bool HasModifierFilename { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTALuaModifierEntry_HasModifierType"></a> HasModifierType

```csharp
public bool HasModifierType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTALuaModifierEntry_ModifierFilename"></a> ModifierFilename

```csharp
public string ModifierFilename { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTALuaModifierEntry_ModifierType"></a> ModifierType

```csharp
public int ModifierType { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTALuaModifierEntry_Parser"></a> Parser

```csharp
public static MessageParser<CDOTALuaModifierEntry> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTALuaModifierEntry](Divine.Protobufs.Dota2.CDOTALuaModifierEntry.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTALuaModifierEntry_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTALuaModifierEntry_ClearModifierFilename"></a> ClearModifierFilename\(\)

```csharp
public void ClearModifierFilename()
```

### <a id="Divine_Protobufs_Dota2_CDOTALuaModifierEntry_ClearModifierType"></a> ClearModifierType\(\)

```csharp
public void ClearModifierType()
```

### <a id="Divine_Protobufs_Dota2_CDOTALuaModifierEntry_Clone"></a> Clone\(\)

```csharp
public CDOTALuaModifierEntry Clone()
```

#### Returns

 [CDOTALuaModifierEntry](Divine.Protobufs.Dota2.CDOTALuaModifierEntry.md)

### <a id="Divine_Protobufs_Dota2_CDOTALuaModifierEntry_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTALuaModifierEntry_Equals_Divine_Protobufs_Dota2_CDOTALuaModifierEntry_"></a> Equals\(CDOTALuaModifierEntry\)

```csharp
public bool Equals(CDOTALuaModifierEntry other)
```

#### Parameters

`other` [CDOTALuaModifierEntry](Divine.Protobufs.Dota2.CDOTALuaModifierEntry.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTALuaModifierEntry_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTALuaModifierEntry_MergeFrom_Divine_Protobufs_Dota2_CDOTALuaModifierEntry_"></a> MergeFrom\(CDOTALuaModifierEntry\)

```csharp
public void MergeFrom(CDOTALuaModifierEntry other)
```

#### Parameters

`other` [CDOTALuaModifierEntry](Divine.Protobufs.Dota2.CDOTALuaModifierEntry.md)

### <a id="Divine_Protobufs_Dota2_CDOTALuaModifierEntry_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTALuaModifierEntry_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTALuaModifierEntry_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

