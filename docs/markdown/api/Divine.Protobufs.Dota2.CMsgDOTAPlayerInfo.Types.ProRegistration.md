# <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_ProRegistration"></a> Class CMsgDOTAPlayerInfo.Types.ProRegistration

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAPlayerInfo.Types.ProRegistration : IMessage<CMsgDOTAPlayerInfo.Types.ProRegistration>, IEquatable<CMsgDOTAPlayerInfo.Types.ProRegistration>, IDeepCloneable<CMsgDOTAPlayerInfo.Types.ProRegistration>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAPlayerInfo.Types.ProRegistration](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.ProRegistration.md)

#### Implements

IMessage<CMsgDOTAPlayerInfo.Types.ProRegistration\>, 
[IEquatable<CMsgDOTAPlayerInfo.Types.ProRegistration\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAPlayerInfo.Types.ProRegistration\>, 
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
[EnumerableExtensions.In<CMsgDOTAPlayerInfo.Types.ProRegistration\>\(CMsgDOTAPlayerInfo.Types.ProRegistration, params CMsgDOTAPlayerInfo.Types.ProRegistration\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_ProRegistration__ctor"></a> ProRegistration\(\)

```csharp
public ProRegistration()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_ProRegistration__ctor_Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_ProRegistration_"></a> ProRegistration\(ProRegistration\)

```csharp
public ProRegistration(CMsgDOTAPlayerInfo.Types.ProRegistration other)
```

#### Parameters

`other` [CMsgDOTAPlayerInfo](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.md).[ProRegistration](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.ProRegistration.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_ProRegistration_RegistrationPeriodFieldNumber"></a> RegistrationPeriodFieldNumber

```csharp
public const int RegistrationPeriodFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_ProRegistration_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_ProRegistration_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_ProRegistration_HasRegistrationPeriod"></a> HasRegistrationPeriod

```csharp
public bool HasRegistrationPeriod { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_ProRegistration_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_ProRegistration_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAPlayerInfo.Types.ProRegistration> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAPlayerInfo](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.md).[ProRegistration](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.ProRegistration.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_ProRegistration_RegistrationPeriod"></a> RegistrationPeriod

```csharp
public uint RegistrationPeriod { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_ProRegistration_Timestamp"></a> Timestamp

```csharp
public uint Timestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_ProRegistration_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_ProRegistration_ClearRegistrationPeriod"></a> ClearRegistrationPeriod\(\)

```csharp
public void ClearRegistrationPeriod()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_ProRegistration_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_ProRegistration_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAPlayerInfo.Types.ProRegistration Clone()
```

#### Returns

 [CMsgDOTAPlayerInfo](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.md).[ProRegistration](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.ProRegistration.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_ProRegistration_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_ProRegistration_Equals_Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_ProRegistration_"></a> Equals\(ProRegistration\)

```csharp
public bool Equals(CMsgDOTAPlayerInfo.Types.ProRegistration other)
```

#### Parameters

`other` [CMsgDOTAPlayerInfo](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.md).[ProRegistration](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.ProRegistration.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_ProRegistration_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_ProRegistration_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_ProRegistration_"></a> MergeFrom\(ProRegistration\)

```csharp
public void MergeFrom(CMsgDOTAPlayerInfo.Types.ProRegistration other)
```

#### Parameters

`other` [CMsgDOTAPlayerInfo](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.md).[ProRegistration](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.ProRegistration.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_ProRegistration_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_ProRegistration_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_ProRegistration_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

