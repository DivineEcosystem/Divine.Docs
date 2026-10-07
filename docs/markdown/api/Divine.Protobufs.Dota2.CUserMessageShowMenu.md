# <a id="Divine_Protobufs_Dota2_CUserMessageShowMenu"></a> Class CUserMessageShowMenu

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessageShowMenu : IMessage<CUserMessageShowMenu>, IEquatable<CUserMessageShowMenu>, IDeepCloneable<CUserMessageShowMenu>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessageShowMenu](Divine.Protobufs.Dota2.CUserMessageShowMenu.md)

#### Implements

IMessage<CUserMessageShowMenu\>, 
[IEquatable<CUserMessageShowMenu\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessageShowMenu\>, 
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
[EnumerableExtensions.In<CUserMessageShowMenu\>\(CUserMessageShowMenu, params CUserMessageShowMenu\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessageShowMenu__ctor"></a> CUserMessageShowMenu\(\)

```csharp
public CUserMessageShowMenu()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageShowMenu__ctor_Divine_Protobufs_Dota2_CUserMessageShowMenu_"></a> CUserMessageShowMenu\(CUserMessageShowMenu\)

```csharp
public CUserMessageShowMenu(CUserMessageShowMenu other)
```

#### Parameters

`other` [CUserMessageShowMenu](Divine.Protobufs.Dota2.CUserMessageShowMenu.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessageShowMenu_DisplaytimeFieldNumber"></a> DisplaytimeFieldNumber

```csharp
public const int DisplaytimeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageShowMenu_MenustringFieldNumber"></a> MenustringFieldNumber

```csharp
public const int MenustringFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageShowMenu_NeedmoreFieldNumber"></a> NeedmoreFieldNumber

```csharp
public const int NeedmoreFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageShowMenu_ValidslotsFieldNumber"></a> ValidslotsFieldNumber

```csharp
public const int ValidslotsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessageShowMenu_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessageShowMenu_Displaytime"></a> Displaytime

```csharp
public uint Displaytime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CUserMessageShowMenu_HasDisplaytime"></a> HasDisplaytime

```csharp
public bool HasDisplaytime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageShowMenu_HasMenustring"></a> HasMenustring

```csharp
public bool HasMenustring { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageShowMenu_HasNeedmore"></a> HasNeedmore

```csharp
public bool HasNeedmore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageShowMenu_HasValidslots"></a> HasValidslots

```csharp
public bool HasValidslots { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageShowMenu_Menustring"></a> Menustring

```csharp
public string Menustring { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageShowMenu_Needmore"></a> Needmore

```csharp
public bool Needmore { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageShowMenu_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessageShowMenu> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessageShowMenu](Divine.Protobufs.Dota2.CUserMessageShowMenu.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMessageShowMenu_Validslots"></a> Validslots

```csharp
public uint Validslots { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessageShowMenu_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageShowMenu_ClearDisplaytime"></a> ClearDisplaytime\(\)

```csharp
public void ClearDisplaytime()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageShowMenu_ClearMenustring"></a> ClearMenustring\(\)

```csharp
public void ClearMenustring()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageShowMenu_ClearNeedmore"></a> ClearNeedmore\(\)

```csharp
public void ClearNeedmore()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageShowMenu_ClearValidslots"></a> ClearValidslots\(\)

```csharp
public void ClearValidslots()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageShowMenu_Clone"></a> Clone\(\)

```csharp
public CUserMessageShowMenu Clone()
```

#### Returns

 [CUserMessageShowMenu](Divine.Protobufs.Dota2.CUserMessageShowMenu.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageShowMenu_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageShowMenu_Equals_Divine_Protobufs_Dota2_CUserMessageShowMenu_"></a> Equals\(CUserMessageShowMenu\)

```csharp
public bool Equals(CUserMessageShowMenu other)
```

#### Parameters

`other` [CUserMessageShowMenu](Divine.Protobufs.Dota2.CUserMessageShowMenu.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageShowMenu_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageShowMenu_MergeFrom_Divine_Protobufs_Dota2_CUserMessageShowMenu_"></a> MergeFrom\(CUserMessageShowMenu\)

```csharp
public void MergeFrom(CUserMessageShowMenu other)
```

#### Parameters

`other` [CUserMessageShowMenu](Divine.Protobufs.Dota2.CUserMessageShowMenu.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageShowMenu_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessageShowMenu_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageShowMenu_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

