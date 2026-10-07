# <a id="Divine_Protobufs_Dota2_CMsgPartyReadyCheckAcknowledge"></a> Class CMsgPartyReadyCheckAcknowledge

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPartyReadyCheckAcknowledge : IMessage<CMsgPartyReadyCheckAcknowledge>, IEquatable<CMsgPartyReadyCheckAcknowledge>, IDeepCloneable<CMsgPartyReadyCheckAcknowledge>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPartyReadyCheckAcknowledge](Divine.Protobufs.Dota2.CMsgPartyReadyCheckAcknowledge.md)

#### Implements

IMessage<CMsgPartyReadyCheckAcknowledge\>, 
[IEquatable<CMsgPartyReadyCheckAcknowledge\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPartyReadyCheckAcknowledge\>, 
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
[EnumerableExtensions.In<CMsgPartyReadyCheckAcknowledge\>\(CMsgPartyReadyCheckAcknowledge, params CMsgPartyReadyCheckAcknowledge\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPartyReadyCheckAcknowledge__ctor"></a> CMsgPartyReadyCheckAcknowledge\(\)

```csharp
public CMsgPartyReadyCheckAcknowledge()
```

### <a id="Divine_Protobufs_Dota2_CMsgPartyReadyCheckAcknowledge__ctor_Divine_Protobufs_Dota2_CMsgPartyReadyCheckAcknowledge_"></a> CMsgPartyReadyCheckAcknowledge\(CMsgPartyReadyCheckAcknowledge\)

```csharp
public CMsgPartyReadyCheckAcknowledge(CMsgPartyReadyCheckAcknowledge other)
```

#### Parameters

`other` [CMsgPartyReadyCheckAcknowledge](Divine.Protobufs.Dota2.CMsgPartyReadyCheckAcknowledge.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPartyReadyCheckAcknowledge_ReadyStatusFieldNumber"></a> ReadyStatusFieldNumber

```csharp
public const int ReadyStatusFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPartyReadyCheckAcknowledge_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPartyReadyCheckAcknowledge_HasReadyStatus"></a> HasReadyStatus

```csharp
public bool HasReadyStatus { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPartyReadyCheckAcknowledge_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPartyReadyCheckAcknowledge> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPartyReadyCheckAcknowledge](Divine.Protobufs.Dota2.CMsgPartyReadyCheckAcknowledge.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPartyReadyCheckAcknowledge_ReadyStatus"></a> ReadyStatus

```csharp
public EReadyCheckStatus ReadyStatus { get; set; }
```

#### Property Value

 [EReadyCheckStatus](Divine.Protobufs.Dota2.EReadyCheckStatus.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPartyReadyCheckAcknowledge_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPartyReadyCheckAcknowledge_ClearReadyStatus"></a> ClearReadyStatus\(\)

```csharp
public void ClearReadyStatus()
```

### <a id="Divine_Protobufs_Dota2_CMsgPartyReadyCheckAcknowledge_Clone"></a> Clone\(\)

```csharp
public CMsgPartyReadyCheckAcknowledge Clone()
```

#### Returns

 [CMsgPartyReadyCheckAcknowledge](Divine.Protobufs.Dota2.CMsgPartyReadyCheckAcknowledge.md)

### <a id="Divine_Protobufs_Dota2_CMsgPartyReadyCheckAcknowledge_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPartyReadyCheckAcknowledge_Equals_Divine_Protobufs_Dota2_CMsgPartyReadyCheckAcknowledge_"></a> Equals\(CMsgPartyReadyCheckAcknowledge\)

```csharp
public bool Equals(CMsgPartyReadyCheckAcknowledge other)
```

#### Parameters

`other` [CMsgPartyReadyCheckAcknowledge](Divine.Protobufs.Dota2.CMsgPartyReadyCheckAcknowledge.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPartyReadyCheckAcknowledge_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPartyReadyCheckAcknowledge_MergeFrom_Divine_Protobufs_Dota2_CMsgPartyReadyCheckAcknowledge_"></a> MergeFrom\(CMsgPartyReadyCheckAcknowledge\)

```csharp
public void MergeFrom(CMsgPartyReadyCheckAcknowledge other)
```

#### Parameters

`other` [CMsgPartyReadyCheckAcknowledge](Divine.Protobufs.Dota2.CMsgPartyReadyCheckAcknowledge.md)

### <a id="Divine_Protobufs_Dota2_CMsgPartyReadyCheckAcknowledge_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPartyReadyCheckAcknowledge_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPartyReadyCheckAcknowledge_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

