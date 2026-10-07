# <a id="Divine_Protobufs_Dota2_CMsgDevModifyCodexAction"></a> Class CMsgDevModifyCodexAction

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDevModifyCodexAction : IMessage<CMsgDevModifyCodexAction>, IEquatable<CMsgDevModifyCodexAction>, IDeepCloneable<CMsgDevModifyCodexAction>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDevModifyCodexAction](Divine.Protobufs.Dota2.CMsgDevModifyCodexAction.md)

#### Implements

IMessage<CMsgDevModifyCodexAction\>, 
[IEquatable<CMsgDevModifyCodexAction\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDevModifyCodexAction\>, 
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
[EnumerableExtensions.In<CMsgDevModifyCodexAction\>\(CMsgDevModifyCodexAction, params CMsgDevModifyCodexAction\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDevModifyCodexAction__ctor"></a> CMsgDevModifyCodexAction\(\)

```csharp
public CMsgDevModifyCodexAction()
```

### <a id="Divine_Protobufs_Dota2_CMsgDevModifyCodexAction__ctor_Divine_Protobufs_Dota2_CMsgDevModifyCodexAction_"></a> CMsgDevModifyCodexAction\(CMsgDevModifyCodexAction\)

```csharp
public CMsgDevModifyCodexAction(CMsgDevModifyCodexAction other)
```

#### Parameters

`other` [CMsgDevModifyCodexAction](Divine.Protobufs.Dota2.CMsgDevModifyCodexAction.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDevModifyCodexAction_ActionFieldNumber"></a> ActionFieldNumber

```csharp
public const int ActionFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDevModifyCodexAction_CodexIdFieldNumber"></a> CodexIdFieldNumber

```csharp
public const int CodexIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDevModifyCodexAction_StatTypeFieldNumber"></a> StatTypeFieldNumber

```csharp
public const int StatTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDevModifyCodexAction_Action"></a> Action

```csharp
public CMsgDevModifyCodexAction.Types.EAction Action { get; set; }
```

#### Property Value

 [CMsgDevModifyCodexAction](Divine.Protobufs.Dota2.CMsgDevModifyCodexAction.md).[Types](Divine.Protobufs.Dota2.CMsgDevModifyCodexAction.Types.md).[EAction](Divine.Protobufs.Dota2.CMsgDevModifyCodexAction.Types.EAction.md)

### <a id="Divine_Protobufs_Dota2_CMsgDevModifyCodexAction_CodexId"></a> CodexId

```csharp
public uint CodexId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDevModifyCodexAction_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDevModifyCodexAction_HasAction"></a> HasAction

```csharp
public bool HasAction { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDevModifyCodexAction_HasCodexId"></a> HasCodexId

```csharp
public bool HasCodexId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDevModifyCodexAction_HasStatType"></a> HasStatType

```csharp
public bool HasStatType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDevModifyCodexAction_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDevModifyCodexAction> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDevModifyCodexAction](Divine.Protobufs.Dota2.CMsgDevModifyCodexAction.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDevModifyCodexAction_StatType"></a> StatType

```csharp
public EHeroCodexEntryStatType StatType { get; set; }
```

#### Property Value

 [EHeroCodexEntryStatType](Divine.Protobufs.Dota2.EHeroCodexEntryStatType.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDevModifyCodexAction_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDevModifyCodexAction_ClearAction"></a> ClearAction\(\)

```csharp
public void ClearAction()
```

### <a id="Divine_Protobufs_Dota2_CMsgDevModifyCodexAction_ClearCodexId"></a> ClearCodexId\(\)

```csharp
public void ClearCodexId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDevModifyCodexAction_ClearStatType"></a> ClearStatType\(\)

```csharp
public void ClearStatType()
```

### <a id="Divine_Protobufs_Dota2_CMsgDevModifyCodexAction_Clone"></a> Clone\(\)

```csharp
public CMsgDevModifyCodexAction Clone()
```

#### Returns

 [CMsgDevModifyCodexAction](Divine.Protobufs.Dota2.CMsgDevModifyCodexAction.md)

### <a id="Divine_Protobufs_Dota2_CMsgDevModifyCodexAction_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDevModifyCodexAction_Equals_Divine_Protobufs_Dota2_CMsgDevModifyCodexAction_"></a> Equals\(CMsgDevModifyCodexAction\)

```csharp
public bool Equals(CMsgDevModifyCodexAction other)
```

#### Parameters

`other` [CMsgDevModifyCodexAction](Divine.Protobufs.Dota2.CMsgDevModifyCodexAction.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDevModifyCodexAction_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDevModifyCodexAction_MergeFrom_Divine_Protobufs_Dota2_CMsgDevModifyCodexAction_"></a> MergeFrom\(CMsgDevModifyCodexAction\)

```csharp
public void MergeFrom(CMsgDevModifyCodexAction other)
```

#### Parameters

`other` [CMsgDevModifyCodexAction](Divine.Protobufs.Dota2.CMsgDevModifyCodexAction.md)

### <a id="Divine_Protobufs_Dota2_CMsgDevModifyCodexAction_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDevModifyCodexAction_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDevModifyCodexAction_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

