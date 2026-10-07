# <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDef"></a> Class CMsgGCItemEditorReserveItemDef

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCItemEditorReserveItemDef : IMessage<CMsgGCItemEditorReserveItemDef>, IEquatable<CMsgGCItemEditorReserveItemDef>, IDeepCloneable<CMsgGCItemEditorReserveItemDef>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCItemEditorReserveItemDef](Divine.Protobufs.Dota2.CMsgGCItemEditorReserveItemDef.md)

#### Implements

IMessage<CMsgGCItemEditorReserveItemDef\>, 
[IEquatable<CMsgGCItemEditorReserveItemDef\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCItemEditorReserveItemDef\>, 
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
[EnumerableExtensions.In<CMsgGCItemEditorReserveItemDef\>\(CMsgGCItemEditorReserveItemDef, params CMsgGCItemEditorReserveItemDef\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDef__ctor"></a> CMsgGCItemEditorReserveItemDef\(\)

```csharp
public CMsgGCItemEditorReserveItemDef()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDef__ctor_Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDef_"></a> CMsgGCItemEditorReserveItemDef\(CMsgGCItemEditorReserveItemDef\)

```csharp
public CMsgGCItemEditorReserveItemDef(CMsgGCItemEditorReserveItemDef other)
```

#### Parameters

`other` [CMsgGCItemEditorReserveItemDef](Divine.Protobufs.Dota2.CMsgGCItemEditorReserveItemDef.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDef_DefIndexFieldNumber"></a> DefIndexFieldNumber

```csharp
public const int DefIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDef_UsernameFieldNumber"></a> UsernameFieldNumber

```csharp
public const int UsernameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDef_DefIndex"></a> DefIndex

```csharp
public uint DefIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDef_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDef_HasDefIndex"></a> HasDefIndex

```csharp
public bool HasDefIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDef_HasUsername"></a> HasUsername

```csharp
public bool HasUsername { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDef_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCItemEditorReserveItemDef> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCItemEditorReserveItemDef](Divine.Protobufs.Dota2.CMsgGCItemEditorReserveItemDef.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDef_Username"></a> Username

```csharp
public string Username { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDef_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDef_ClearDefIndex"></a> ClearDefIndex\(\)

```csharp
public void ClearDefIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDef_ClearUsername"></a> ClearUsername\(\)

```csharp
public void ClearUsername()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDef_Clone"></a> Clone\(\)

```csharp
public CMsgGCItemEditorReserveItemDef Clone()
```

#### Returns

 [CMsgGCItemEditorReserveItemDef](Divine.Protobufs.Dota2.CMsgGCItemEditorReserveItemDef.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDef_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDef_Equals_Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDef_"></a> Equals\(CMsgGCItemEditorReserveItemDef\)

```csharp
public bool Equals(CMsgGCItemEditorReserveItemDef other)
```

#### Parameters

`other` [CMsgGCItemEditorReserveItemDef](Divine.Protobufs.Dota2.CMsgGCItemEditorReserveItemDef.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDef_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDef_MergeFrom_Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDef_"></a> MergeFrom\(CMsgGCItemEditorReserveItemDef\)

```csharp
public void MergeFrom(CMsgGCItemEditorReserveItemDef other)
```

#### Parameters

`other` [CMsgGCItemEditorReserveItemDef](Divine.Protobufs.Dota2.CMsgGCItemEditorReserveItemDef.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDef_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDef_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDef_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

