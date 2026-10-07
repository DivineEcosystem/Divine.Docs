# <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2"></a> Class CMsgAMGrantGuestPasses2

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgAMGrantGuestPasses2 : IMessage<CMsgAMGrantGuestPasses2>, IEquatable<CMsgAMGrantGuestPasses2>, IDeepCloneable<CMsgAMGrantGuestPasses2>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgAMGrantGuestPasses2](Divine.Protobufs.Steam.CMsgAMGrantGuestPasses2.md)

#### Implements

IMessage<CMsgAMGrantGuestPasses2\>, 
[IEquatable<CMsgAMGrantGuestPasses2\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgAMGrantGuestPasses2\>, 
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
[EnumerableExtensions.In<CMsgAMGrantGuestPasses2\>\(CMsgAMGrantGuestPasses2, params CMsgAMGrantGuestPasses2\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2__ctor"></a> CMsgAMGrantGuestPasses2\(\)

```csharp
public CMsgAMGrantGuestPasses2()
```

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2__ctor_Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2_"></a> CMsgAMGrantGuestPasses2\(CMsgAMGrantGuestPasses2\)

```csharp
public CMsgAMGrantGuestPasses2(CMsgAMGrantGuestPasses2 other)
```

#### Parameters

`other` [CMsgAMGrantGuestPasses2](Divine.Protobufs.Steam.CMsgAMGrantGuestPasses2.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2_ActionFieldNumber"></a> ActionFieldNumber

```csharp
public const int ActionFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2_DaysToExpirationFieldNumber"></a> DaysToExpirationFieldNumber

```csharp
public const int DaysToExpirationFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2_PackageIdFieldNumber"></a> PackageIdFieldNumber

```csharp
public const int PackageIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2_PassesToGrantFieldNumber"></a> PassesToGrantFieldNumber

```csharp
public const int PassesToGrantFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2_SteamIdFieldNumber"></a> SteamIdFieldNumber

```csharp
public const int SteamIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2_Action"></a> Action

```csharp
public int Action { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2_DaysToExpiration"></a> DaysToExpiration

```csharp
public int DaysToExpiration { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2_HasAction"></a> HasAction

```csharp
public bool HasAction { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2_HasDaysToExpiration"></a> HasDaysToExpiration

```csharp
public bool HasDaysToExpiration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2_HasPackageId"></a> HasPackageId

```csharp
public bool HasPackageId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2_HasPassesToGrant"></a> HasPassesToGrant

```csharp
public bool HasPassesToGrant { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2_HasSteamId"></a> HasSteamId

```csharp
public bool HasSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2_PackageId"></a> PackageId

```csharp
public uint PackageId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2_Parser"></a> Parser

```csharp
public static MessageParser<CMsgAMGrantGuestPasses2> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgAMGrantGuestPasses2](Divine.Protobufs.Steam.CMsgAMGrantGuestPasses2.md)\>

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2_PassesToGrant"></a> PassesToGrant

```csharp
public int PassesToGrant { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2_SteamId"></a> SteamId

```csharp
public ulong SteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2_ClearAction"></a> ClearAction\(\)

```csharp
public void ClearAction()
```

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2_ClearDaysToExpiration"></a> ClearDaysToExpiration\(\)

```csharp
public void ClearDaysToExpiration()
```

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2_ClearPackageId"></a> ClearPackageId\(\)

```csharp
public void ClearPackageId()
```

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2_ClearPassesToGrant"></a> ClearPassesToGrant\(\)

```csharp
public void ClearPassesToGrant()
```

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2_ClearSteamId"></a> ClearSteamId\(\)

```csharp
public void ClearSteamId()
```

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2_Clone"></a> Clone\(\)

```csharp
public CMsgAMGrantGuestPasses2 Clone()
```

#### Returns

 [CMsgAMGrantGuestPasses2](Divine.Protobufs.Steam.CMsgAMGrantGuestPasses2.md)

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2_Equals_Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2_"></a> Equals\(CMsgAMGrantGuestPasses2\)

```csharp
public bool Equals(CMsgAMGrantGuestPasses2 other)
```

#### Parameters

`other` [CMsgAMGrantGuestPasses2](Divine.Protobufs.Steam.CMsgAMGrantGuestPasses2.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2_MergeFrom_Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2_"></a> MergeFrom\(CMsgAMGrantGuestPasses2\)

```csharp
public void MergeFrom(CMsgAMGrantGuestPasses2 other)
```

#### Parameters

`other` [CMsgAMGrantGuestPasses2](Divine.Protobufs.Steam.CMsgAMGrantGuestPasses2.md)

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

