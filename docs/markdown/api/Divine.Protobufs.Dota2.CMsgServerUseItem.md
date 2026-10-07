# <a id="Divine_Protobufs_Dota2_CMsgServerUseItem"></a> Class CMsgServerUseItem

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerUseItem : IMessage<CMsgServerUseItem>, IEquatable<CMsgServerUseItem>, IDeepCloneable<CMsgServerUseItem>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerUseItem](Divine.Protobufs.Dota2.CMsgServerUseItem.md)

#### Implements

IMessage<CMsgServerUseItem\>, 
[IEquatable<CMsgServerUseItem\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerUseItem\>, 
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
[EnumerableExtensions.In<CMsgServerUseItem\>\(CMsgServerUseItem, params CMsgServerUseItem\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerUseItem__ctor"></a> CMsgServerUseItem\(\)

```csharp
public CMsgServerUseItem()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerUseItem__ctor_Divine_Protobufs_Dota2_CMsgServerUseItem_"></a> CMsgServerUseItem\(CMsgServerUseItem\)

```csharp
public CMsgServerUseItem(CMsgServerUseItem other)
```

#### Parameters

`other` [CMsgServerUseItem](Divine.Protobufs.Dota2.CMsgServerUseItem.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerUseItem_InitiatorAccountIdFieldNumber"></a> InitiatorAccountIdFieldNumber

```csharp
public const int InitiatorAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerUseItem_UseItemMsgFieldNumber"></a> UseItemMsgFieldNumber

```csharp
public const int UseItemMsgFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerUseItem_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerUseItem_HasInitiatorAccountId"></a> HasInitiatorAccountId

```csharp
public bool HasInitiatorAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerUseItem_InitiatorAccountId"></a> InitiatorAccountId

```csharp
public uint InitiatorAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerUseItem_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerUseItem> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerUseItem](Divine.Protobufs.Dota2.CMsgServerUseItem.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerUseItem_UseItemMsg"></a> UseItemMsg

```csharp
public CMsgUseItem UseItemMsg { get; set; }
```

#### Property Value

 [CMsgUseItem](Divine.Protobufs.Dota2.CMsgUseItem.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerUseItem_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerUseItem_ClearInitiatorAccountId"></a> ClearInitiatorAccountId\(\)

```csharp
public void ClearInitiatorAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerUseItem_Clone"></a> Clone\(\)

```csharp
public CMsgServerUseItem Clone()
```

#### Returns

 [CMsgServerUseItem](Divine.Protobufs.Dota2.CMsgServerUseItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerUseItem_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerUseItem_Equals_Divine_Protobufs_Dota2_CMsgServerUseItem_"></a> Equals\(CMsgServerUseItem\)

```csharp
public bool Equals(CMsgServerUseItem other)
```

#### Parameters

`other` [CMsgServerUseItem](Divine.Protobufs.Dota2.CMsgServerUseItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerUseItem_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerUseItem_MergeFrom_Divine_Protobufs_Dota2_CMsgServerUseItem_"></a> MergeFrom\(CMsgServerUseItem\)

```csharp
public void MergeFrom(CMsgServerUseItem other)
```

#### Parameters

`other` [CMsgServerUseItem](Divine.Protobufs.Dota2.CMsgServerUseItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerUseItem_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerUseItem_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerUseItem_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

