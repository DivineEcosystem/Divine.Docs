# <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountClient_Types_RoleHandicap"></a> Class CSODOTAGameAccountClient.Types.RoleHandicap

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSODOTAGameAccountClient.Types.RoleHandicap : IMessage<CSODOTAGameAccountClient.Types.RoleHandicap>, IEquatable<CSODOTAGameAccountClient.Types.RoleHandicap>, IDeepCloneable<CSODOTAGameAccountClient.Types.RoleHandicap>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSODOTAGameAccountClient.Types.RoleHandicap](Divine.Protobufs.Dota2.CSODOTAGameAccountClient.Types.RoleHandicap.md)

#### Implements

IMessage<CSODOTAGameAccountClient.Types.RoleHandicap\>, 
[IEquatable<CSODOTAGameAccountClient.Types.RoleHandicap\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSODOTAGameAccountClient.Types.RoleHandicap\>, 
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
[EnumerableExtensions.In<CSODOTAGameAccountClient.Types.RoleHandicap\>\(CSODOTAGameAccountClient.Types.RoleHandicap, params CSODOTAGameAccountClient.Types.RoleHandicap\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountClient_Types_RoleHandicap__ctor"></a> RoleHandicap\(\)

```csharp
public RoleHandicap()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountClient_Types_RoleHandicap__ctor_Divine_Protobufs_Dota2_CSODOTAGameAccountClient_Types_RoleHandicap_"></a> RoleHandicap\(RoleHandicap\)

```csharp
public RoleHandicap(CSODOTAGameAccountClient.Types.RoleHandicap other)
```

#### Parameters

`other` [CSODOTAGameAccountClient](Divine.Protobufs.Dota2.CSODOTAGameAccountClient.md).[Types](Divine.Protobufs.Dota2.CSODOTAGameAccountClient.Types.md).[RoleHandicap](Divine.Protobufs.Dota2.CSODOTAGameAccountClient.Types.RoleHandicap.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountClient_Types_RoleHandicap_HandicapFieldNumber"></a> HandicapFieldNumber

```csharp
public const int HandicapFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountClient_Types_RoleHandicap_RoleFieldNumber"></a> RoleFieldNumber

```csharp
public const int RoleFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountClient_Types_RoleHandicap_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountClient_Types_RoleHandicap_Handicap"></a> Handicap

```csharp
public float Handicap { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountClient_Types_RoleHandicap_HasHandicap"></a> HasHandicap

```csharp
public bool HasHandicap { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountClient_Types_RoleHandicap_HasRole"></a> HasRole

```csharp
public bool HasRole { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountClient_Types_RoleHandicap_Parser"></a> Parser

```csharp
public static MessageParser<CSODOTAGameAccountClient.Types.RoleHandicap> Parser { get; }
```

#### Property Value

 MessageParser<[CSODOTAGameAccountClient](Divine.Protobufs.Dota2.CSODOTAGameAccountClient.md).[Types](Divine.Protobufs.Dota2.CSODOTAGameAccountClient.Types.md).[RoleHandicap](Divine.Protobufs.Dota2.CSODOTAGameAccountClient.Types.RoleHandicap.md)\>

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountClient_Types_RoleHandicap_Role"></a> Role

```csharp
public uint Role { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountClient_Types_RoleHandicap_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountClient_Types_RoleHandicap_ClearHandicap"></a> ClearHandicap\(\)

```csharp
public void ClearHandicap()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountClient_Types_RoleHandicap_ClearRole"></a> ClearRole\(\)

```csharp
public void ClearRole()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountClient_Types_RoleHandicap_Clone"></a> Clone\(\)

```csharp
public CSODOTAGameAccountClient.Types.RoleHandicap Clone()
```

#### Returns

 [CSODOTAGameAccountClient](Divine.Protobufs.Dota2.CSODOTAGameAccountClient.md).[Types](Divine.Protobufs.Dota2.CSODOTAGameAccountClient.Types.md).[RoleHandicap](Divine.Protobufs.Dota2.CSODOTAGameAccountClient.Types.RoleHandicap.md)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountClient_Types_RoleHandicap_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountClient_Types_RoleHandicap_Equals_Divine_Protobufs_Dota2_CSODOTAGameAccountClient_Types_RoleHandicap_"></a> Equals\(RoleHandicap\)

```csharp
public bool Equals(CSODOTAGameAccountClient.Types.RoleHandicap other)
```

#### Parameters

`other` [CSODOTAGameAccountClient](Divine.Protobufs.Dota2.CSODOTAGameAccountClient.md).[Types](Divine.Protobufs.Dota2.CSODOTAGameAccountClient.Types.md).[RoleHandicap](Divine.Protobufs.Dota2.CSODOTAGameAccountClient.Types.RoleHandicap.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountClient_Types_RoleHandicap_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountClient_Types_RoleHandicap_MergeFrom_Divine_Protobufs_Dota2_CSODOTAGameAccountClient_Types_RoleHandicap_"></a> MergeFrom\(RoleHandicap\)

```csharp
public void MergeFrom(CSODOTAGameAccountClient.Types.RoleHandicap other)
```

#### Parameters

`other` [CSODOTAGameAccountClient](Divine.Protobufs.Dota2.CSODOTAGameAccountClient.md).[Types](Divine.Protobufs.Dota2.CSODOTAGameAccountClient.Types.md).[RoleHandicap](Divine.Protobufs.Dota2.CSODOTAGameAccountClient.Types.RoleHandicap.md)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountClient_Types_RoleHandicap_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountClient_Types_RoleHandicap_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSODOTAGameAccountClient_Types_RoleHandicap_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

