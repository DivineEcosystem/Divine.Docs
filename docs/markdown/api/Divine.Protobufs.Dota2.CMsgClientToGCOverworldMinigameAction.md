# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction"></a> Class CMsgClientToGCOverworldMinigameAction

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverworldMinigameAction : IMessage<CMsgClientToGCOverworldMinigameAction>, IEquatable<CMsgClientToGCOverworldMinigameAction>, IDeepCloneable<CMsgClientToGCOverworldMinigameAction>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverworldMinigameAction](Divine.Protobufs.Dota2.CMsgClientToGCOverworldMinigameAction.md)

#### Implements

IMessage<CMsgClientToGCOverworldMinigameAction\>, 
[IEquatable<CMsgClientToGCOverworldMinigameAction\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverworldMinigameAction\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverworldMinigameAction\>\(CMsgClientToGCOverworldMinigameAction, params CMsgClientToGCOverworldMinigameAction\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction__ctor"></a> CMsgClientToGCOverworldMinigameAction\(\)

```csharp
public CMsgClientToGCOverworldMinigameAction()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction_"></a> CMsgClientToGCOverworldMinigameAction\(CMsgClientToGCOverworldMinigameAction\)

```csharp
public CMsgClientToGCOverworldMinigameAction(CMsgClientToGCOverworldMinigameAction other)
```

#### Parameters

`other` [CMsgClientToGCOverworldMinigameAction](Divine.Protobufs.Dota2.CMsgClientToGCOverworldMinigameAction.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction_ActionFieldNumber"></a> ActionFieldNumber

```csharp
public const int ActionFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction_CurrencyAmountFieldNumber"></a> CurrencyAmountFieldNumber

```csharp
public const int CurrencyAmountFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction_NodeIdFieldNumber"></a> NodeIdFieldNumber

```csharp
public const int NodeIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction_OptionValueFieldNumber"></a> OptionValueFieldNumber

```csharp
public const int OptionValueFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction_OverworldIdFieldNumber"></a> OverworldIdFieldNumber

```csharp
public const int OverworldIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction_SelectionFieldNumber"></a> SelectionFieldNumber

```csharp
public const int SelectionFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction_Action"></a> Action

```csharp
public EOverworldMinigameAction Action { get; set; }
```

#### Property Value

 [EOverworldMinigameAction](Divine.Protobufs.Dota2.EOverworldMinigameAction.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction_CurrencyAmount"></a> CurrencyAmount

```csharp
public uint CurrencyAmount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction_HasAction"></a> HasAction

```csharp
public bool HasAction { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction_HasCurrencyAmount"></a> HasCurrencyAmount

```csharp
public bool HasCurrencyAmount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction_HasNodeId"></a> HasNodeId

```csharp
public bool HasNodeId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction_HasOptionValue"></a> HasOptionValue

```csharp
public bool HasOptionValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction_HasOverworldId"></a> HasOverworldId

```csharp
public bool HasOverworldId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction_HasSelection"></a> HasSelection

```csharp
public bool HasSelection { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction_NodeId"></a> NodeId

```csharp
public uint NodeId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction_OptionValue"></a> OptionValue

```csharp
public uint OptionValue { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction_OverworldId"></a> OverworldId

```csharp
public uint OverworldId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverworldMinigameAction> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverworldMinigameAction](Divine.Protobufs.Dota2.CMsgClientToGCOverworldMinigameAction.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction_Selection"></a> Selection

```csharp
public uint Selection { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction_ClearAction"></a> ClearAction\(\)

```csharp
public void ClearAction()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction_ClearCurrencyAmount"></a> ClearCurrencyAmount\(\)

```csharp
public void ClearCurrencyAmount()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction_ClearNodeId"></a> ClearNodeId\(\)

```csharp
public void ClearNodeId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction_ClearOptionValue"></a> ClearOptionValue\(\)

```csharp
public void ClearOptionValue()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction_ClearOverworldId"></a> ClearOverworldId\(\)

```csharp
public void ClearOverworldId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction_ClearSelection"></a> ClearSelection\(\)

```csharp
public void ClearSelection()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverworldMinigameAction Clone()
```

#### Returns

 [CMsgClientToGCOverworldMinigameAction](Divine.Protobufs.Dota2.CMsgClientToGCOverworldMinigameAction.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction_"></a> Equals\(CMsgClientToGCOverworldMinigameAction\)

```csharp
public bool Equals(CMsgClientToGCOverworldMinigameAction other)
```

#### Parameters

`other` [CMsgClientToGCOverworldMinigameAction](Divine.Protobufs.Dota2.CMsgClientToGCOverworldMinigameAction.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction_"></a> MergeFrom\(CMsgClientToGCOverworldMinigameAction\)

```csharp
public void MergeFrom(CMsgClientToGCOverworldMinigameAction other)
```

#### Parameters

`other` [CMsgClientToGCOverworldMinigameAction](Divine.Protobufs.Dota2.CMsgClientToGCOverworldMinigameAction.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameAction_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

