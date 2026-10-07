# <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_Types_PingWheelMessageRange"></a> Class CMsgAdditionalLobbyStartupAccountData.Types.PingWheelMessageRange

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgAdditionalLobbyStartupAccountData.Types.PingWheelMessageRange : IMessage<CMsgAdditionalLobbyStartupAccountData.Types.PingWheelMessageRange>, IEquatable<CMsgAdditionalLobbyStartupAccountData.Types.PingWheelMessageRange>, IDeepCloneable<CMsgAdditionalLobbyStartupAccountData.Types.PingWheelMessageRange>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgAdditionalLobbyStartupAccountData.Types.PingWheelMessageRange](Divine.Protobufs.Dota2.CMsgAdditionalLobbyStartupAccountData.Types.PingWheelMessageRange.md)

#### Implements

IMessage<CMsgAdditionalLobbyStartupAccountData.Types.PingWheelMessageRange\>, 
[IEquatable<CMsgAdditionalLobbyStartupAccountData.Types.PingWheelMessageRange\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgAdditionalLobbyStartupAccountData.Types.PingWheelMessageRange\>, 
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
[EnumerableExtensions.In<CMsgAdditionalLobbyStartupAccountData.Types.PingWheelMessageRange\>\(CMsgAdditionalLobbyStartupAccountData.Types.PingWheelMessageRange, params CMsgAdditionalLobbyStartupAccountData.Types.PingWheelMessageRange\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_Types_PingWheelMessageRange__ctor"></a> PingWheelMessageRange\(\)

```csharp
public PingWheelMessageRange()
```

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_Types_PingWheelMessageRange__ctor_Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_Types_PingWheelMessageRange_"></a> PingWheelMessageRange\(PingWheelMessageRange\)

```csharp
public PingWheelMessageRange(CMsgAdditionalLobbyStartupAccountData.Types.PingWheelMessageRange other)
```

#### Parameters

`other` [CMsgAdditionalLobbyStartupAccountData](Divine.Protobufs.Dota2.CMsgAdditionalLobbyStartupAccountData.md).[Types](Divine.Protobufs.Dota2.CMsgAdditionalLobbyStartupAccountData.Types.md).[PingWheelMessageRange](Divine.Protobufs.Dota2.CMsgAdditionalLobbyStartupAccountData.Types.PingWheelMessageRange.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_Types_PingWheelMessageRange_MessageIdEndFieldNumber"></a> MessageIdEndFieldNumber

```csharp
public const int MessageIdEndFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_Types_PingWheelMessageRange_MessageIdStartFieldNumber"></a> MessageIdStartFieldNumber

```csharp
public const int MessageIdStartFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_Types_PingWheelMessageRange_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_Types_PingWheelMessageRange_HasMessageIdEnd"></a> HasMessageIdEnd

```csharp
public bool HasMessageIdEnd { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_Types_PingWheelMessageRange_HasMessageIdStart"></a> HasMessageIdStart

```csharp
public bool HasMessageIdStart { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_Types_PingWheelMessageRange_MessageIdEnd"></a> MessageIdEnd

```csharp
public uint MessageIdEnd { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_Types_PingWheelMessageRange_MessageIdStart"></a> MessageIdStart

```csharp
public uint MessageIdStart { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_Types_PingWheelMessageRange_Parser"></a> Parser

```csharp
public static MessageParser<CMsgAdditionalLobbyStartupAccountData.Types.PingWheelMessageRange> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgAdditionalLobbyStartupAccountData](Divine.Protobufs.Dota2.CMsgAdditionalLobbyStartupAccountData.md).[Types](Divine.Protobufs.Dota2.CMsgAdditionalLobbyStartupAccountData.Types.md).[PingWheelMessageRange](Divine.Protobufs.Dota2.CMsgAdditionalLobbyStartupAccountData.Types.PingWheelMessageRange.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_Types_PingWheelMessageRange_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_Types_PingWheelMessageRange_ClearMessageIdEnd"></a> ClearMessageIdEnd\(\)

```csharp
public void ClearMessageIdEnd()
```

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_Types_PingWheelMessageRange_ClearMessageIdStart"></a> ClearMessageIdStart\(\)

```csharp
public void ClearMessageIdStart()
```

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_Types_PingWheelMessageRange_Clone"></a> Clone\(\)

```csharp
public CMsgAdditionalLobbyStartupAccountData.Types.PingWheelMessageRange Clone()
```

#### Returns

 [CMsgAdditionalLobbyStartupAccountData](Divine.Protobufs.Dota2.CMsgAdditionalLobbyStartupAccountData.md).[Types](Divine.Protobufs.Dota2.CMsgAdditionalLobbyStartupAccountData.Types.md).[PingWheelMessageRange](Divine.Protobufs.Dota2.CMsgAdditionalLobbyStartupAccountData.Types.PingWheelMessageRange.md)

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_Types_PingWheelMessageRange_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_Types_PingWheelMessageRange_Equals_Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_Types_PingWheelMessageRange_"></a> Equals\(PingWheelMessageRange\)

```csharp
public bool Equals(CMsgAdditionalLobbyStartupAccountData.Types.PingWheelMessageRange other)
```

#### Parameters

`other` [CMsgAdditionalLobbyStartupAccountData](Divine.Protobufs.Dota2.CMsgAdditionalLobbyStartupAccountData.md).[Types](Divine.Protobufs.Dota2.CMsgAdditionalLobbyStartupAccountData.Types.md).[PingWheelMessageRange](Divine.Protobufs.Dota2.CMsgAdditionalLobbyStartupAccountData.Types.PingWheelMessageRange.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_Types_PingWheelMessageRange_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_Types_PingWheelMessageRange_MergeFrom_Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_Types_PingWheelMessageRange_"></a> MergeFrom\(PingWheelMessageRange\)

```csharp
public void MergeFrom(CMsgAdditionalLobbyStartupAccountData.Types.PingWheelMessageRange other)
```

#### Parameters

`other` [CMsgAdditionalLobbyStartupAccountData](Divine.Protobufs.Dota2.CMsgAdditionalLobbyStartupAccountData.md).[Types](Divine.Protobufs.Dota2.CMsgAdditionalLobbyStartupAccountData.Types.md).[PingWheelMessageRange](Divine.Protobufs.Dota2.CMsgAdditionalLobbyStartupAccountData.Types.PingWheelMessageRange.md)

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_Types_PingWheelMessageRange_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_Types_PingWheelMessageRange_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_Types_PingWheelMessageRange_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

