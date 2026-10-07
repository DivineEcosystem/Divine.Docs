# <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_Types_key_t"></a> Class CMsgSource1LegacyGameEventList.Types.key\_t

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSource1LegacyGameEventList.Types.key_t : IMessage<CMsgSource1LegacyGameEventList.Types.key_t>, IEquatable<CMsgSource1LegacyGameEventList.Types.key_t>, IDeepCloneable<CMsgSource1LegacyGameEventList.Types.key_t>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSource1LegacyGameEventList.Types.key\_t](Divine.Protobufs.Dota2.CMsgSource1LegacyGameEventList.Types.key\_t.md)

#### Implements

IMessage<CMsgSource1LegacyGameEventList.Types.key\_t\>, 
[IEquatable<CMsgSource1LegacyGameEventList.Types.key\_t\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSource1LegacyGameEventList.Types.key\_t\>, 
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
[EnumerableExtensions.In<CMsgSource1LegacyGameEventList.Types.key\_t\>\(CMsgSource1LegacyGameEventList.Types.key\_t, params CMsgSource1LegacyGameEventList.Types.key\_t\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_Types_key_t__ctor"></a> key\_t\(\)

```csharp
public key_t()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_Types_key_t__ctor_Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_Types_key_t_"></a> key\_t\(key\_t\)

```csharp
public key_t(CMsgSource1LegacyGameEventList.Types.key_t other)
```

#### Parameters

`other` [CMsgSource1LegacyGameEventList](Divine.Protobufs.Dota2.CMsgSource1LegacyGameEventList.md).[Types](Divine.Protobufs.Dota2.CMsgSource1LegacyGameEventList.Types.md).[key\_t](Divine.Protobufs.Dota2.CMsgSource1LegacyGameEventList.Types.key\_t.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_Types_key_t_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_Types_key_t_TypeFieldNumber"></a> TypeFieldNumber

```csharp
public const int TypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_Types_key_t_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_Types_key_t_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_Types_key_t_HasType"></a> HasType

```csharp
public bool HasType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_Types_key_t_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_Types_key_t_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSource1LegacyGameEventList.Types.key_t> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSource1LegacyGameEventList](Divine.Protobufs.Dota2.CMsgSource1LegacyGameEventList.md).[Types](Divine.Protobufs.Dota2.CMsgSource1LegacyGameEventList.Types.md).[key\_t](Divine.Protobufs.Dota2.CMsgSource1LegacyGameEventList.Types.key\_t.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_Types_key_t_Type"></a> Type

```csharp
public int Type { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_Types_key_t_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_Types_key_t_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_Types_key_t_ClearType"></a> ClearType\(\)

```csharp
public void ClearType()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_Types_key_t_Clone"></a> Clone\(\)

```csharp
public CMsgSource1LegacyGameEventList.Types.key_t Clone()
```

#### Returns

 [CMsgSource1LegacyGameEventList](Divine.Protobufs.Dota2.CMsgSource1LegacyGameEventList.md).[Types](Divine.Protobufs.Dota2.CMsgSource1LegacyGameEventList.Types.md).[key\_t](Divine.Protobufs.Dota2.CMsgSource1LegacyGameEventList.Types.key\_t.md)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_Types_key_t_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_Types_key_t_Equals_Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_Types_key_t_"></a> Equals\(key\_t\)

```csharp
public bool Equals(CMsgSource1LegacyGameEventList.Types.key_t other)
```

#### Parameters

`other` [CMsgSource1LegacyGameEventList](Divine.Protobufs.Dota2.CMsgSource1LegacyGameEventList.md).[Types](Divine.Protobufs.Dota2.CMsgSource1LegacyGameEventList.Types.md).[key\_t](Divine.Protobufs.Dota2.CMsgSource1LegacyGameEventList.Types.key\_t.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_Types_key_t_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_Types_key_t_MergeFrom_Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_Types_key_t_"></a> MergeFrom\(key\_t\)

```csharp
public void MergeFrom(CMsgSource1LegacyGameEventList.Types.key_t other)
```

#### Parameters

`other` [CMsgSource1LegacyGameEventList](Divine.Protobufs.Dota2.CMsgSource1LegacyGameEventList.md).[Types](Divine.Protobufs.Dota2.CMsgSource1LegacyGameEventList.Types.md).[key\_t](Divine.Protobufs.Dota2.CMsgSource1LegacyGameEventList.Types.key\_t.md)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_Types_key_t_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_Types_key_t_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEventList_Types_key_t_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

