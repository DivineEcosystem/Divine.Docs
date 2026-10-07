# <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemAction"></a> Class CMsgItemBattlerItemAction

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgItemBattlerItemAction : IMessage<CMsgItemBattlerItemAction>, IEquatable<CMsgItemBattlerItemAction>, IDeepCloneable<CMsgItemBattlerItemAction>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgItemBattlerItemAction](Divine.Protobufs.Dota2.CMsgItemBattlerItemAction.md)

#### Implements

IMessage<CMsgItemBattlerItemAction\>, 
[IEquatable<CMsgItemBattlerItemAction\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgItemBattlerItemAction\>, 
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
[EnumerableExtensions.In<CMsgItemBattlerItemAction\>\(CMsgItemBattlerItemAction, params CMsgItemBattlerItemAction\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemAction__ctor"></a> CMsgItemBattlerItemAction\(\)

```csharp
public CMsgItemBattlerItemAction()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemAction__ctor_Divine_Protobufs_Dota2_CMsgItemBattlerItemAction_"></a> CMsgItemBattlerItemAction\(CMsgItemBattlerItemAction\)

```csharp
public CMsgItemBattlerItemAction(CMsgItemBattlerItemAction other)
```

#### Parameters

`other` [CMsgItemBattlerItemAction](Divine.Protobufs.Dota2.CMsgItemBattlerItemAction.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemAction_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemAction_Parser"></a> Parser

```csharp
public static MessageParser<CMsgItemBattlerItemAction> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgItemBattlerItemAction](Divine.Protobufs.Dota2.CMsgItemBattlerItemAction.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemAction_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemAction_Clone"></a> Clone\(\)

```csharp
public CMsgItemBattlerItemAction Clone()
```

#### Returns

 [CMsgItemBattlerItemAction](Divine.Protobufs.Dota2.CMsgItemBattlerItemAction.md)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemAction_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemAction_Equals_Divine_Protobufs_Dota2_CMsgItemBattlerItemAction_"></a> Equals\(CMsgItemBattlerItemAction\)

```csharp
public bool Equals(CMsgItemBattlerItemAction other)
```

#### Parameters

`other` [CMsgItemBattlerItemAction](Divine.Protobufs.Dota2.CMsgItemBattlerItemAction.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemAction_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemAction_MergeFrom_Divine_Protobufs_Dota2_CMsgItemBattlerItemAction_"></a> MergeFrom\(CMsgItemBattlerItemAction\)

```csharp
public void MergeFrom(CMsgItemBattlerItemAction other)
```

#### Parameters

`other` [CMsgItemBattlerItemAction](Divine.Protobufs.Dota2.CMsgItemBattlerItemAction.md)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemAction_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemAction_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemAction_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

