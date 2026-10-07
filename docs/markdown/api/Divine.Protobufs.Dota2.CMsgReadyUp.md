# <a id="Divine_Protobufs_Dota2_CMsgReadyUp"></a> Class CMsgReadyUp

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgReadyUp : IMessage<CMsgReadyUp>, IEquatable<CMsgReadyUp>, IDeepCloneable<CMsgReadyUp>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgReadyUp](Divine.Protobufs.Dota2.CMsgReadyUp.md)

#### Implements

IMessage<CMsgReadyUp\>, 
[IEquatable<CMsgReadyUp\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgReadyUp\>, 
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
[EnumerableExtensions.In<CMsgReadyUp\>\(CMsgReadyUp, params CMsgReadyUp\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgReadyUp__ctor"></a> CMsgReadyUp\(\)

```csharp
public CMsgReadyUp()
```

### <a id="Divine_Protobufs_Dota2_CMsgReadyUp__ctor_Divine_Protobufs_Dota2_CMsgReadyUp_"></a> CMsgReadyUp\(CMsgReadyUp\)

```csharp
public CMsgReadyUp(CMsgReadyUp other)
```

#### Parameters

`other` [CMsgReadyUp](Divine.Protobufs.Dota2.CMsgReadyUp.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgReadyUp_HardwareSpecsFieldNumber"></a> HardwareSpecsFieldNumber

```csharp
public const int HardwareSpecsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgReadyUp_ReadyUpKeyFieldNumber"></a> ReadyUpKeyFieldNumber

```csharp
public const int ReadyUpKeyFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgReadyUp_StateFieldNumber"></a> StateFieldNumber

```csharp
public const int StateFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgReadyUp_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgReadyUp_HardwareSpecs"></a> HardwareSpecs

```csharp
public CDOTAClientHardwareSpecs HardwareSpecs { get; set; }
```

#### Property Value

 [CDOTAClientHardwareSpecs](Divine.Protobufs.Dota2.CDOTAClientHardwareSpecs.md)

### <a id="Divine_Protobufs_Dota2_CMsgReadyUp_HasReadyUpKey"></a> HasReadyUpKey

```csharp
public bool HasReadyUpKey { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgReadyUp_HasState"></a> HasState

```csharp
public bool HasState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgReadyUp_Parser"></a> Parser

```csharp
public static MessageParser<CMsgReadyUp> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgReadyUp](Divine.Protobufs.Dota2.CMsgReadyUp.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgReadyUp_ReadyUpKey"></a> ReadyUpKey

```csharp
public ulong ReadyUpKey { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgReadyUp_State"></a> State

```csharp
public DOTALobbyReadyState State { get; set; }
```

#### Property Value

 [DOTALobbyReadyState](Divine.Protobufs.Dota2.DOTALobbyReadyState.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgReadyUp_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgReadyUp_ClearReadyUpKey"></a> ClearReadyUpKey\(\)

```csharp
public void ClearReadyUpKey()
```

### <a id="Divine_Protobufs_Dota2_CMsgReadyUp_ClearState"></a> ClearState\(\)

```csharp
public void ClearState()
```

### <a id="Divine_Protobufs_Dota2_CMsgReadyUp_Clone"></a> Clone\(\)

```csharp
public CMsgReadyUp Clone()
```

#### Returns

 [CMsgReadyUp](Divine.Protobufs.Dota2.CMsgReadyUp.md)

### <a id="Divine_Protobufs_Dota2_CMsgReadyUp_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgReadyUp_Equals_Divine_Protobufs_Dota2_CMsgReadyUp_"></a> Equals\(CMsgReadyUp\)

```csharp
public bool Equals(CMsgReadyUp other)
```

#### Parameters

`other` [CMsgReadyUp](Divine.Protobufs.Dota2.CMsgReadyUp.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgReadyUp_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgReadyUp_MergeFrom_Divine_Protobufs_Dota2_CMsgReadyUp_"></a> MergeFrom\(CMsgReadyUp\)

```csharp
public void MergeFrom(CMsgReadyUp other)
```

#### Parameters

`other` [CMsgReadyUp](Divine.Protobufs.Dota2.CMsgReadyUp.md)

### <a id="Divine_Protobufs_Dota2_CMsgReadyUp_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgReadyUp_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgReadyUp_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

