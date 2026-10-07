# <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdatePartyBeacon"></a> Class CMsgClientToGCUpdatePartyBeacon

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCUpdatePartyBeacon : IMessage<CMsgClientToGCUpdatePartyBeacon>, IEquatable<CMsgClientToGCUpdatePartyBeacon>, IDeepCloneable<CMsgClientToGCUpdatePartyBeacon>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCUpdatePartyBeacon](Divine.Protobufs.Dota2.CMsgClientToGCUpdatePartyBeacon.md)

#### Implements

IMessage<CMsgClientToGCUpdatePartyBeacon\>, 
[IEquatable<CMsgClientToGCUpdatePartyBeacon\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCUpdatePartyBeacon\>, 
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
[EnumerableExtensions.In<CMsgClientToGCUpdatePartyBeacon\>\(CMsgClientToGCUpdatePartyBeacon, params CMsgClientToGCUpdatePartyBeacon\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdatePartyBeacon__ctor"></a> CMsgClientToGCUpdatePartyBeacon\(\)

```csharp
public CMsgClientToGCUpdatePartyBeacon()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdatePartyBeacon__ctor_Divine_Protobufs_Dota2_CMsgClientToGCUpdatePartyBeacon_"></a> CMsgClientToGCUpdatePartyBeacon\(CMsgClientToGCUpdatePartyBeacon\)

```csharp
public CMsgClientToGCUpdatePartyBeacon(CMsgClientToGCUpdatePartyBeacon other)
```

#### Parameters

`other` [CMsgClientToGCUpdatePartyBeacon](Divine.Protobufs.Dota2.CMsgClientToGCUpdatePartyBeacon.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdatePartyBeacon_ActionFieldNumber"></a> ActionFieldNumber

```csharp
public const int ActionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdatePartyBeacon_Action"></a> Action

```csharp
public CMsgClientToGCUpdatePartyBeacon.Types.Action Action { get; set; }
```

#### Property Value

 [CMsgClientToGCUpdatePartyBeacon](Divine.Protobufs.Dota2.CMsgClientToGCUpdatePartyBeacon.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCUpdatePartyBeacon.Types.md).[Action](Divine.Protobufs.Dota2.CMsgClientToGCUpdatePartyBeacon.Types.Action.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdatePartyBeacon_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdatePartyBeacon_HasAction"></a> HasAction

```csharp
public bool HasAction { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdatePartyBeacon_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCUpdatePartyBeacon> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCUpdatePartyBeacon](Divine.Protobufs.Dota2.CMsgClientToGCUpdatePartyBeacon.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdatePartyBeacon_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdatePartyBeacon_ClearAction"></a> ClearAction\(\)

```csharp
public void ClearAction()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdatePartyBeacon_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCUpdatePartyBeacon Clone()
```

#### Returns

 [CMsgClientToGCUpdatePartyBeacon](Divine.Protobufs.Dota2.CMsgClientToGCUpdatePartyBeacon.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdatePartyBeacon_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdatePartyBeacon_Equals_Divine_Protobufs_Dota2_CMsgClientToGCUpdatePartyBeacon_"></a> Equals\(CMsgClientToGCUpdatePartyBeacon\)

```csharp
public bool Equals(CMsgClientToGCUpdatePartyBeacon other)
```

#### Parameters

`other` [CMsgClientToGCUpdatePartyBeacon](Divine.Protobufs.Dota2.CMsgClientToGCUpdatePartyBeacon.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdatePartyBeacon_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdatePartyBeacon_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCUpdatePartyBeacon_"></a> MergeFrom\(CMsgClientToGCUpdatePartyBeacon\)

```csharp
public void MergeFrom(CMsgClientToGCUpdatePartyBeacon other)
```

#### Parameters

`other` [CMsgClientToGCUpdatePartyBeacon](Divine.Protobufs.Dota2.CMsgClientToGCUpdatePartyBeacon.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdatePartyBeacon_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdatePartyBeacon_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdatePartyBeacon_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

