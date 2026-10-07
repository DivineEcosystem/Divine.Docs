# <a id="Divine_Protobufs_Steam_CPlayer_CommunityPreferences"></a> Class CPlayer\_CommunityPreferences

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CPlayer_CommunityPreferences : IMessage<CPlayer_CommunityPreferences>, IEquatable<CPlayer_CommunityPreferences>, IDeepCloneable<CPlayer_CommunityPreferences>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CPlayer\_CommunityPreferences](Divine.Protobufs.Steam.CPlayer\_CommunityPreferences.md)

#### Implements

IMessage<CPlayer\_CommunityPreferences\>, 
[IEquatable<CPlayer\_CommunityPreferences\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CPlayer\_CommunityPreferences\>, 
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
[EnumerableExtensions.In<CPlayer\_CommunityPreferences\>\(CPlayer\_CommunityPreferences, params CPlayer\_CommunityPreferences\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CPlayer_CommunityPreferences__ctor"></a> CPlayer\_CommunityPreferences\(\)

```csharp
public CPlayer_CommunityPreferences()
```

### <a id="Divine_Protobufs_Steam_CPlayer_CommunityPreferences__ctor_Divine_Protobufs_Steam_CPlayer_CommunityPreferences_"></a> CPlayer\_CommunityPreferences\(CPlayer\_CommunityPreferences\)

```csharp
public CPlayer_CommunityPreferences(CPlayer_CommunityPreferences other)
```

#### Parameters

`other` [CPlayer\_CommunityPreferences](Divine.Protobufs.Steam.CPlayer\_CommunityPreferences.md)

## Fields

### <a id="Divine_Protobufs_Steam_CPlayer_CommunityPreferences_HideAdultContentSexFieldNumber"></a> HideAdultContentSexFieldNumber

```csharp
public const int HideAdultContentSexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_CommunityPreferences_HideAdultContentViolenceFieldNumber"></a> HideAdultContentViolenceFieldNumber

```csharp
public const int HideAdultContentViolenceFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_CommunityPreferences_ParenthesizeNicknamesFieldNumber"></a> ParenthesizeNicknamesFieldNumber

```csharp
public const int ParenthesizeNicknamesFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_CommunityPreferences_TimestampUpdatedFieldNumber"></a> TimestampUpdatedFieldNumber

```csharp
public const int TimestampUpdatedFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CPlayer_CommunityPreferences_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CPlayer_CommunityPreferences_HasHideAdultContentSex"></a> HasHideAdultContentSex

```csharp
public bool HasHideAdultContentSex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_CommunityPreferences_HasHideAdultContentViolence"></a> HasHideAdultContentViolence

```csharp
public bool HasHideAdultContentViolence { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_CommunityPreferences_HasParenthesizeNicknames"></a> HasParenthesizeNicknames

```csharp
public bool HasParenthesizeNicknames { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_CommunityPreferences_HasTimestampUpdated"></a> HasTimestampUpdated

```csharp
public bool HasTimestampUpdated { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_CommunityPreferences_HideAdultContentSex"></a> HideAdultContentSex

```csharp
public bool HideAdultContentSex { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_CommunityPreferences_HideAdultContentViolence"></a> HideAdultContentViolence

```csharp
public bool HideAdultContentViolence { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_CommunityPreferences_ParenthesizeNicknames"></a> ParenthesizeNicknames

```csharp
public bool ParenthesizeNicknames { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_CommunityPreferences_Parser"></a> Parser

```csharp
public static MessageParser<CPlayer_CommunityPreferences> Parser { get; }
```

#### Property Value

 MessageParser<[CPlayer\_CommunityPreferences](Divine.Protobufs.Steam.CPlayer\_CommunityPreferences.md)\>

### <a id="Divine_Protobufs_Steam_CPlayer_CommunityPreferences_TimestampUpdated"></a> TimestampUpdated

```csharp
public uint TimestampUpdated { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CPlayer_CommunityPreferences_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_CommunityPreferences_ClearHideAdultContentSex"></a> ClearHideAdultContentSex\(\)

```csharp
public void ClearHideAdultContentSex()
```

### <a id="Divine_Protobufs_Steam_CPlayer_CommunityPreferences_ClearHideAdultContentViolence"></a> ClearHideAdultContentViolence\(\)

```csharp
public void ClearHideAdultContentViolence()
```

### <a id="Divine_Protobufs_Steam_CPlayer_CommunityPreferences_ClearParenthesizeNicknames"></a> ClearParenthesizeNicknames\(\)

```csharp
public void ClearParenthesizeNicknames()
```

### <a id="Divine_Protobufs_Steam_CPlayer_CommunityPreferences_ClearTimestampUpdated"></a> ClearTimestampUpdated\(\)

```csharp
public void ClearTimestampUpdated()
```

### <a id="Divine_Protobufs_Steam_CPlayer_CommunityPreferences_Clone"></a> Clone\(\)

```csharp
public CPlayer_CommunityPreferences Clone()
```

#### Returns

 [CPlayer\_CommunityPreferences](Divine.Protobufs.Steam.CPlayer\_CommunityPreferences.md)

### <a id="Divine_Protobufs_Steam_CPlayer_CommunityPreferences_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_CommunityPreferences_Equals_Divine_Protobufs_Steam_CPlayer_CommunityPreferences_"></a> Equals\(CPlayer\_CommunityPreferences\)

```csharp
public bool Equals(CPlayer_CommunityPreferences other)
```

#### Parameters

`other` [CPlayer\_CommunityPreferences](Divine.Protobufs.Steam.CPlayer\_CommunityPreferences.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_CommunityPreferences_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_CommunityPreferences_MergeFrom_Divine_Protobufs_Steam_CPlayer_CommunityPreferences_"></a> MergeFrom\(CPlayer\_CommunityPreferences\)

```csharp
public void MergeFrom(CPlayer_CommunityPreferences other)
```

#### Parameters

`other` [CPlayer\_CommunityPreferences](Divine.Protobufs.Steam.CPlayer\_CommunityPreferences.md)

### <a id="Divine_Protobufs_Steam_CPlayer_CommunityPreferences_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CPlayer_CommunityPreferences_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CPlayer_CommunityPreferences_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

